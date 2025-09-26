using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using _INNO;
using _INNO._Net;

namespace _INNO._Net
{
    public class InnoNetTcpTestServer : InnoTcpBase
    {
        // UI 표시를 위한 queue로 필요시에만 만들어 사용하면 됩니다. (전역으로 필요한 경우 _Global 등에 Queue 정의하여 사용하면 됩니다.)
        public _INNO._Data.InnoQueue<string> _uiQueue = new _INNO._Data.InnoQueue<string>();

        public void Start(int port)
        {
            StartServer(port);
        }

        public void Stop()
        {
            StopServer();
        }

        public new bool IsRunning()
        {
            return IsServerRunning();
        }

        // 정보가 변경되면 호출됩니다.
        protected override void OnInfo(object sender, InnoNetTcpInfoEventArgs e)
        {
            _uiQueue.Push($"[Server] Code={e.Code} Message={e.Message}");

            switch (e.Code)
            {
                case InnoNetTcpInfoEventArgs._eCode.ClientConnected: break;
                case InnoNetTcpInfoEventArgs._eCode.Disconnected: break;
            }
        }

        // 에러가 발생하면 호출됩니다.
        protected override void OnError(object sender, InnoNetTcpErrorEventArgs e)
        {
            _uiQueue.Push($"[Server.Error] Code={e.Code} Message={e.Message}");

            switch (e.Code)
            {
                case InnoNetTcpErrorEventArgs._eCode.ReadThreadException: break;
            }
        }

        // [0x02][FULLDATA][0x03]이 정상적으로 수신되면 호출되는 Thread 함수입니다.
        protected override void OnReadQueueProcess(object sender, EventArgs e)
        {
            object objData = null;
            string strData = "";

            try
            {
                if (_ReadQueue == null || _ReadQueue.Count <= 0)
                {
                    return;
                }

                objData = _ReadQueue.Pop();

                if (objData != null)
                {
                    strData = objData.ToString();

                    if (strData[0] == '{') // Json이면 just Pass
                        _uiQueue.Push($"{strData}");
                    else
                        _uiQueue.Push($"[S  <-C] {strData}");

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
            string strData = "";

            try
            {
                if (_SendQueue == null || _SendQueue.Count <= 0)
                {
                    return;
                }

                objData = _SendQueue.Pop();

                if (objData != null)
                {
                    strData = objData.ToString();

                    _uiQueue.Push($"[S->  C] {strData}");

                    Send(strData);
                }
            }
            catch (Exception ex)
            {
                _uiQueue.Push($"OnSendQueueProcessException Exception={ex}");
            }
        }
    }
}
