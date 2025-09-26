//================================================================================
//
// _Device.DevRadianQBio_Indicator
//
//================================================================================
//                                   Copyright @ Innosoft 2019. http://innosoft.kr
//                      Copyright @ (주)북스 BOOX, Inc. 2023. http://www.boox.co.kr
//                                   Andy Yang - booxboox@naver.com, 010-3292-3892
//================================================================================
// [생성]
// 1. 작성자 : Andy Yang
// 2. 작성일 : 2024-07-15
//--------------------------------------------------------------------------------
// [설명]
// 1. 라디안큐바이오 인디케이터 제어 (로드셀)
//--------------------------------------------------------------------------------
// [이력]
// <날짜>      <작성자>   <설명>
// 2024-07-15 Andy Yang  Initial.
//================================================================================
//
using _INNO;
using _INNO._Dev;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _Device
{
    public class DevRadianQBio_Indicator : InnoSerialAbstract<DevRadianQBio_Indicator>
    {
        private int IDNumber = 0; // 통신 장비 번호 설정

        private Thread sendThread;
        private bool isSendThread = false;
        private bool isContinueSending = true;

        private static object _Lock = new Object();

        public DevRadianQBio_Indicator()
        {
            base.SetCommandStartEndBytes(new byte[] { 0x49, 0x44 }, new byte[] { 0x0D, 0x0A });
        }

        public bool Open(string portName)
        {
            bool ret = base.Open(portName, 9600);

            StartSendThread();

            return ret;
        }

        public new void Close()
        {
            StopSendThread();
            base.Close();
        }

        public void SetIDNumber(int idNumber)
        {
            IDNumber = idNumber;
        }

        public int GetIDNumber()
        {
            return IDNumber;
        }

        private bool Send_Command(byte command = (byte)'P')
        {
            lock (_Lock)
            {
                if (this.IsOpen == false) return false;

                byte[] idNumArray = new byte[] { 0x00, 0x00 };
                idNumArray = GetIDNumber().ToString().ToByteArray(2);

                byte[] protocol = new byte[] { 0x49, 0x44, 0x30, 0x31, command };
                protocol[2] = idNumArray[0];
                protocol[3] = idNumArray[1];

                return base.Send(protocol);
            }
        }

        public bool Send_GetCurrentValue()
        {
            // 현재 디바이스의 설정된 수신 데이터는 ID,01,+0123456{CR}{LF} 로 "+0123456"값을 g 단위로 전달받도록 설정되어 있다.
            return Send_Command((byte)'P');
        }

        public bool Send_SetZero()
        {
            bool ret = false;

            isContinueSending = false;
            Thread.Sleep(50);
            ret = Send_Command((byte)'Z');
            isContinueSending = true;

            return ret;
        }

        public bool Send_Hold()
        {
            bool ret = false;

            isContinueSending = false;
            Thread.Sleep(100);
            ret = Send_Command((byte)'Z');
            isContinueSending = true;

            return ret;
        }

        public bool Send_Release()
        {
            bool ret = false;

            isContinueSending = false;
            Thread.Sleep(100);
            ret = Send_Command((byte)'R');
            isContinueSending = true;

            return ret;
        }

        private void StartSendThread()
        {
            isSendThread = true;
            sendThread = new Thread(new ThreadStart(SendThread));
            sendThread.Start();
        }

        private void StopSendThread()
        {
            if (isSendThread)
            {
                isSendThread = false;
                if (Thread.CurrentThread != sendThread)
                    sendThread.Join();
            }
        }

        private void SendThread()
        {
            while (isSendThread)
            {
                Thread.Sleep(100);

                try
                {
                    if (isContinueSending) Send_GetCurrentValue();
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.ToString());
                }
            }
        }

    }
}
