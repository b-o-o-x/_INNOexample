//================================================================================
//
// _INNO._Net.InnoNetTcpClientSample
//
//================================================================================
//                     Copyright @ (주)북스 BOOX, Inc. 2023. http://www.boox.co.kr
//                    Copyright @ 이노소프트 Innosoft Co. 2019. http://innosoft.kr
//                                대표 양승민 | 010-3292-3892 | booxboox@naver.com
//================================================================================
// [생성]
// 1. 작성자 : Andy Yang
// 2. 작성일 : 2023-03-16
//--------------------------------------------------------------------------------
// [설명]
// 1. TCP Client Sample Class
//--------------------------------------------------------------------------------
// [이력]
// <날짜>   <작성자>   <설명>
// 23-03-17 Andy Yang Initial Version. (간단히 사용하기 위한 목적의 TcpClientSample)
// 24-12-22 Andy Yang TcpClient.Start() 함수 외에 TcpClient.Connect() 함수 추가함.
// 25-01-15 Andy Yang  1) Exception 처리 방식 옵션화 적용 (Throw, Notify)
//================================================================================
//
using _INNO._Data;
using _INNO._Net;
using System;

namespace _Custom
{
    /// <summary>
    /// TcpClient Sample : Sample용으로만 사용하고, 정석적으로는 InnoNetTcpBase를 상속받는 클래스를 생성하여 사용하십시오.
    /// </summary>
    public class InnoTcpClientSample : InnoTcpBase
    {
        //##
        //## 바로 InnoNetTcpXXXSample을 직접 사용하는 프로젝트의 경우 받은 데이터 처리를 할 수 없어 귀찮아서 queue에 다 때려넣어줌.
        //##

        // UI 표시를 위한 queue로 필요시에만 만들어 사용하면 됩니다. (전역으로 필요한 경우 _Global 등에 Queue 정의하여 사용하면 됩니다.)
        //public _INNO.InnoDataQueue<string> _uiQueue = new _INNO.InnoDataQueue<string>();

        /// <summary>
        /// 전체 메시지 내용을 포함하는 Queue
        /// </summary>
        public InnoQueue<string> _uiQueue = new InnoQueue<string>(); // UI (전체 포함)
        /// <summary>
        /// Info 메시지 내용을 포함하는 Queue
        /// </summary>
        public InnoQueue<string> _uiInfoQueue = new InnoQueue<string>(); // Info
        /// <summary>
        /// Error 메시지 내용을 포함하는 Queue
        /// </summary>
        public InnoQueue<string> _uiErrorQueue = new InnoQueue<string>(); // Error
        /// <summary>
        /// Read 메시지 내용을 포함하는 Queue
        /// </summary>
        public InnoQueue<string> _uiReadQueue = new InnoQueue<string>(); // Read용
        /// <summary>
        /// Send 메시지 내용을 포함하는 Queue
        /// </summary>
        public InnoQueue<string> _uiSendQueue = new InnoQueue<string>(); // Send용

        /// <summary>
        /// TCP 클라이언트를 시작합니다.
        /// </summary>
        /// <param name="ipAddr"></param>
        /// <param name="port"></param>
        public void Start(string ipAddr, int port)
        {
            StartClient(ipAddr, port);
        }

        /// <summary>
        /// TCP 클라이언트를 시작합니다.
        /// </summary>
        /// <param name="ipAddr"></param>
        /// <param name="port"></param>
        public void Connect(string ipAddr, int port)
        {
            StartClient(ipAddr, port);
        }

        /// <summary>
        /// TCP 클라이언트를 정지합니다.
        /// </summary>
        public void Stop()
        {
            StopClient();
        }

        /// <summary>
        /// STX, ETX를 자동으로 붙이지 않고 전달된 data를 그대로 전송합니다.
        /// </summary>
        /// <param name="data"></param>
        public void SendCommand(string data)
        {
            SendRaw(data);
        }

        /// <summary>
        /// 정보가 변경되면 호출됩니다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected override void OnInfo(object sender, InnoNetTcpInfoEventArgs e)
        {
            // UI queue
            string dtNow = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff");
            string uiMsg = $"[{dtNow}][Client] Code={e.Code} Message={e.Message}";
            _uiQueue.Push(uiMsg);

            // Info queue
            string infoMsg = $"Code={e.Code} Message={e.Message}";
            _uiInfoQueue.Push(infoMsg);

            switch (e.Code)
            {
                case InnoNetTcpInfoEventArgs._eCode.ClientConnected: break;
                case InnoNetTcpInfoEventArgs._eCode.Disconnected: break;
            }
        }

        /// <summary>
        /// 에러가 발생하면 호출됩니다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected override void OnError(object sender, InnoNetTcpErrorEventArgs e)
        {
            // UI queue
            string dtNow = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff");
            string uiMsg = $"[{dtNow}][Client.Error] Code={e.Code} Message={e.Message}";
            _uiQueue.Push(uiMsg);

            // Error queue
            string errMsg = $"Code={e.Code} Message={e.Message}";
            _uiErrorQueue.Push(errMsg);

            switch (e.Code)
            {
                case InnoNetTcpErrorEventArgs._eCode.ReadThreadException: break;
            }
        }

        /// <summary>
        /// [STX]FULLDATA[ETX]가 정상적으로 수신되면 호출되는 Thread 함수입니다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected override void OnReadQueueProcess(object sender, EventArgs e)
        {
            object objData = null;
            string strData = "";

            try
            {
                if (base._ReadQueue == null || base._ReadQueue.Count <= 0)
                {
                    return;
                }

                objData = base._ReadQueue.Pop();

                if (objData != null)
                {
                    strData = objData.ToString();

                    // UI queue
                    string dtNow = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff");
                    string uiMsg = $"[READ][{dtNow}][S  ->C] {strData}";
                    _uiQueue.Push(uiMsg);

                    // Data queue
                    _uiReadQueue.Push($"{strData}");

                    //
                    // strData 데이터 파싱하여 처리 루틴
                    //
                }
            }
            catch (Exception ex)
            {
            }
        }

        /// <summary>
        /// SendQueue()를 사용하면 호출되는 Thread 함수입니다. (직접 전송하려면 Send()를 사용하세요.)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

                    // UI queue
                    string dtNow = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff");
                    string uiMsg = $"[SEND][{dtNow}][S  <-C] {strData}";
                    _uiQueue.Push(uiMsg);

                    // Send queue
                    _uiSendQueue.Push(strData);

                    Send(strData);
                }
            }
            catch (Exception ex)
            {
            }
        }
    }
}
