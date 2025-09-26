using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using _INNO;
using _INNO._Data;
using _INNO._Time;

namespace _INNO._Net
{
    public class InnoNetTcpTestDeviceClient : InnoTcpBaseByteArray
    {
        //Thread _ReadQueueProcessThread = null;

        public _INNO._Data.InnoQueue<string> _uiQueue = new _INNO._Data.InnoQueue<string>();

        public void Start(string ipAddr, int port)
        {
            StartClient(ipAddr, port);
        }

        public void Connect(string ipAddr, int port)
        {
            StartClient(ipAddr, port);
        }

        public void Stop()
        {
            StopClient();
        }

        public new bool IsRunning()
        {
            return IsClientRunning();
        }

        public void SendCommand(byte[] data)
        {
            SendRaw(data);
        }

        // 정보가 변경되면 호출됩니다.
        protected override void OnInfo(object sender, InnoNetTcpInfoEventArgs e)
        {
            _uiQueue.Push($"[Client] Code={e.Code} Message={e.Message}");

            switch (e.Code)
            {
                case InnoNetTcpInfoEventArgs._eCode.ClientConnected: break;
                case InnoNetTcpInfoEventArgs._eCode.Disconnected: break;
            }
        }

        // 에러가 발생하면 호출됩니다.
        protected override void OnError(object sender, InnoNetTcpErrorEventArgs e)
        {
            _uiQueue.Push($"[Client.Error] Code={e.Code} Message={e.Message}");

            switch (e.Code)
            {
                case InnoNetTcpErrorEventArgs._eCode.ReadThreadException: break;
            }
        }

        // 전체 프로토콜(ex : [0x02][FULLDATA][0x03])이 정상적으로 수신되면 호출되는 Thread 함수입니다.
        protected override void OnReadQueueProcess(object sender, EventArgs e)
        {
            object objData = null;
            //string strData = "";

            try
            {
                if (_ReadQueue == null || _ReadQueue.Count <= 0)
                {
                    return;
                }

                objData = _ReadQueue.Pop();

                if (objData != null)
                {
                    //strData = objData.ToString();

                    _uiQueue.Push($"[S->  C] {((byte[])objData).ToHexString()}");
                    //_uiQueue.Push($"[S->  C] {_InnoData._ConvertByteArrayToHexString((byte[])objData)}");

                    //
                    // strData 데이터 파싱하여 처리 루틴
                    //
                }
            }
            catch (Exception ex)
            {
                _uiQueue.Push($"OnReadQueueProcessException Exception={ex}");
            }
        }

        // SendQueue()를 사용하면 호출되는 Thread 함수입니다. (직접 전송하려면 Send()를 사용하세요.)
        protected override void OnSendQueueProcess(object sender, EventArgs e)
        {
            object objData = null;

            try
            {
                if (_SendQueue == null || _SendQueue.Count <= 0)
                {
                    return;
                }

                objData = _SendQueue.Pop();

                if (objData != null)
                {
                    _uiQueue.Push($"[S  <-C] {objData}");

                    Send((byte[])objData);
                }
            }
            catch (Exception ex)
            {
                _uiQueue.Push($"OnSendQueueProcessException Exception={ex}");
            }
        }
    }
}
