//================================================================================
//
// _Device.DevIFLightController
//
//================================================================================
//                                   Copyright @ Innosoft 2019. http://innosoft.kr
//                      Copyright @ (주)북스 BOOX, Inc. 2023. http://www.boox.co.kr
//                                   Andy Yang - booxboox@naver.com, 010-3292-3892
//================================================================================
// [생성]
// 1. 작성자 : Andy Yang
// 2. 작성일 : 2019-08-01
//--------------------------------------------------------------------------------
// [설명]
// 1. 이미지포커스 조명컨트롤러 제어 (2CH, 4CH 동일)
//--------------------------------------------------------------------------------
// [이력]
// <날짜>     <작성자>   <설명>
// 2019-08-01 Andy Yang Initial.
//================================================================================
//
using _INNO;
using _INNO._Dev;
using _INNO._File;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Device
{
    /// <summary>
    /// DevIFLightController 클래스<br/>
    /// 제품 : 이미지포커스 - 조명컨트롤러 (2CH, 4CH)<br/>
    /// </summary>
    public class DevIFLightController : InnoSerialAbstract<DevIFLightController>
    {
        /// <summary>
        /// 생성자
        /// </summary>
        public DevIFLightController()
        {
            base.SetCommandStartEndBytes(new byte[] { 0x02, 0x06 }, new byte[] { 0x03 });
        }

        /// <summary>
        /// 디바이스를 오픈합니다.
        /// </summary>
        /// <param name="portName"></param>
        /// <returns></returns>
        public bool Open(string portName)
        {
            return base.Open(portName, 9600);
        }

        /// <summary>
        /// 조명값을 설정합니다.
        /// </summary>
        /// <param name="channel"></param>
        /// <param name="lightValue"></param>
        /// <returns></returns>
        public bool SetLight(int channel, int lightValue)
        {
            if (this.IsOpen == false) return false;

            byte[] light = new byte[] { 0x00, 0x00, 0x00 };
            light = lightValue.ToString().ToByteArray(3);

            byte[] cmd = new byte[] { 0x02, 0x31, 0x30, 0x30, 0x30, 0x03 };
            cmd[1] = channel.ToString().ToByteArray()[0];
            cmd[2] = light[0];
            cmd[3] = light[1];
            cmd[4] = light[2];

            return base.Send(cmd);
        }

        /// <summary>
        /// 조명값을 읽어옵니다.
        /// </summary>
        /// <param name="channel"></param>
        /// <returns></returns>
        public int GetLight(int channel)
        {
            int ret = -1;
            if (this.IsOpen == false) return ret;

            byte[] cmd = new byte[] { 0x02, 0x31, 0x52, 0x45, 0x54, 0x03 };
            cmd[1] = channel.ToString().ToByteArray()[0];

            byte[] recv = base.SendAndReceive(cmd, 100);

            if (recv != null && recv.Length == 6)
            {
                if (recv[0] == 0x02 && recv[5] == 0x03 && recv[1] == cmd[1])
                {
                    byte[] light = new byte[3];
                    light[0] = recv[2];
                    light[1] = recv[3];
                    light[2] = recv[4];
                    string s = light.ToAsciiString();
                    ret = Convert.ToInt32(s);
                }
            }
            return ret;
        }

        /// <summary>
        /// 조명을 켜거나 끕니다.
        /// </summary>
        /// <param name="channel"></param>
        /// <param name="on"></param>
        /// <returns></returns>
        public bool SetOn(int channel, bool on = true)
        {
            if (this.IsOpen == false) return false;

            byte[] cmd = new byte[] { 0x02, 0x31, 0x31, 0x4F, 0x4E, 0x03 };
            cmd[1] = channel.ToString().ToByteArray()[0];
            if (!on)
            {
                cmd[2] = 0x4F; cmd[3] = 0x46; cmd[4] = 0x46;
            }

            return base.Send(cmd);
        }
    }
}
