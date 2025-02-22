using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using _INNO;
using _INNO._Data;
using _INNO._Net;

namespace INNOexample
{
    public partial class Form_TcpSample : CustomFormVirtual
    {
        _Custom.InnoTcpServerSample TcpTestServer = new _Custom.InnoTcpServerSample();
        _Custom.InnoTcpClientSample TcpTestClient = new _Custom.InnoTcpClientSample();
        
        // Auto
        Thread ServerAutoSendThread = null;
        Thread ClientAutoSendThread = null;

        public Form_TcpSample()
        {
            InitializeComponent();
        }

        private void Form_3_Load(object sender, EventArgs e)
        {
            SetInterval_TimerVisibleRefresh(10);

            // Device 통신 등을 위한 STX, ETX 사용여부 설정 기능 추가
            TcpTestServer.SetStartByteUse(false);
            TcpTestServer.SetEndByteUse(false);
            TcpTestClient.SetStartByteUse(false);
            TcpTestClient.SetEndByteUse(false);
        }

        private void Form_TcpTester_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Stop_TimerVisibleRefresh();
            TcpTestServer.Stop();
            TcpTestClient.Stop();
        }

        private void AddLog(string msg)
        {
            txtLog.AppendText(msg + "\r\n");
        }

        protected override void TimerVisibleRefresh_Tick(object sender, EventArgs e)
        {
            if (TcpTestServer.IsRunning())
            {
                btnServerStart.Text = "Started";
                btnServerStart.BackColor = Color.LimeGreen;
            }
            else
            {
                btnServerStart.Text = "Stopped";
                btnServerStart.BackColor = Color.Gray;
            }

            if (TcpTestClient.IsConnected() && TcpTestClient.IsRunning())
            {
                btnClientStart.Text = "Started";
                btnClientStart.BackColor = Color.LimeGreen;
            }
            else
            {
                btnClientStart.Text = "Stopped";
                btnClientStart.BackColor = Color.Gray;
            }

            // Simul용으로 간단 사용하는 _uiReadQueue
            if (0 < TcpTestServer._uiQueue.Count)
            {
                for (int i = 0; i < TcpTestServer._uiQueue.Count; i++) 
                {
                    string msg = TcpTestServer._uiQueue.Pop();
                    AddLog(msg);
                }
            }

            if (0 < TcpTestClient._uiQueue.Count)
            {
                for (int i = 0; i < TcpTestClient._uiQueue.Count; i++)
                {
                    string msg = TcpTestClient._uiQueue.Pop();
                    AddLog(msg);
                }
            }


            // Auto
            if (ServerAutoSendThread != null)
            {
                btnServerSendAuto.BackColor = Color.LimeGreen;
            }
            else
            {
                btnServerSendAuto.BackColor= Color.Gray;
            }

            if (ClientAutoSendThread != null)
            {
                btnClientSendAuto.BackColor = Color.LimeGreen;
            }
            else
            {
                btnClientSendAuto.BackColor = Color.Gray;
            }
        }

        private void btnServerStart_Click(object sender, EventArgs e)
        {
            if (TcpTestServer.IsRunning())
            {
                AddLog($"TCP Server Stop.");
                TcpTestServer.Stop();
            }
            else
            {
                string port = txtPort.Text;
                AddLog($"TCP Server Start. (Port={port})");
                TcpTestServer.Start(port.ToInt32());
            }
        }

        private void btnServerStop_Click(object sender, EventArgs e)
        {
            AddLog($"TCP Server Stop.");
            TcpTestServer.Stop();
        }

        private void btnServerSend_Click(object sender, EventArgs e)
        {
            string dtNow = DateTime.Now.ToString("mm:ss.fff");
            string msg = $"[{dtNow}] " + txtServerMessage.Text;
            AddLog($"TCP Server Send. (Msg={msg})");
            AddLog($"TCP Server Send. (Hex={msg.ToByteArray().ToHexString(" ")})");
            TcpTestServer.SendQueue(msg);
            //txtServerMessage.Text = "";
        }

        private void btnClientStart_Click(object sender, EventArgs e)
        {
            if (TcpTestClient.IsConnected())
            {
                AddLog($"TCP Client Stop.");
                TcpTestClient.Stop();
            }
            else
            {
                string ip = txtIP.Text;
                string port = txtPort.Text;
                AddLog($"TCP Client Start. (IP={ip}, Port={port})");
                TcpTestClient.Start(ip, port.ToInt32());
            }
        }

        private void btnClientStop_Click(object sender, EventArgs e)
        {
            AddLog($"TCP Client Stop.");
            TcpTestClient.Stop();
        }

        private void btnServerSendAuto_Click(object sender, EventArgs e)
        {
            // Auto
            if (ServerAutoSendThread == null)
            {
                ServerAutoSendThread = new Thread(new ParameterizedThreadStart(ServerAutoSendThreadProc));
                ServerAutoSendThread.IsBackground = true;
                ServerAutoSendThread.Start();
            }
            else
            {
                //if (!ServerAutoSendThread.Join(3000))
                //{
                //    ServerAutoSendThread?.Abort();
                //}
                ServerAutoSendThread = null;
            }
        }

        private void btnClientSend_Click(object sender, EventArgs e)
        {
            string dtNow = DateTime.Now.ToString("mm:ss.fff");
            string msg = $"[{dtNow}] " + txtClientMessage.Text;
            AddLog($"TCP Client Send. (Msg={msg})");
            AddLog($"TCP Client Send. (Hex={msg.ToByteArray().ToHexString(" ")})");
            TcpTestClient.SendQueue(msg);
            //TcpTestClient.Send(msg);
            //txtClientMessage.Text = "";
        }

        private void btnClientSendAuto_Click(object sender, EventArgs e)
        {
            // Auto
            if (ClientAutoSendThread == null)
            {
                ClientAutoSendThread = new Thread(new ParameterizedThreadStart(ClientAutoSendThreadProc));
                ClientAutoSendThread.IsBackground = true;
                ClientAutoSendThread.Start();
            }
            else
            {
                //if (!ClientAutoSendThread.Join(3000))
                //{
                //    ClientAutoSendThread?.Abort();
                //}
                ClientAutoSendThread = null;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtLog.Clear();
        }

        private void txtServerMessage_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnServerSend.PerformClick();
            }
        }

        private void txtClientMessage_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnClientSend.PerformClick();
            }
        }

        public void ServerAutoSendThreadProc(object obj)
        {
            while (ServerAutoSendThread != null && TcpTestServer.IsRunning())
            {
                string dtNow = DateTime.Now.ToString("HH:mm:ss.fff");
                string msg = $"[SENDING_TIME={dtNow}] " + txtServerMessage.Text;

                TcpTestServer.SendQueue(msg);
                //TcpTestServer.Send(msg);//큰차이없는듯

                Thread.Sleep(100);
            }
        }

        public void ClientAutoSendThreadProc(object obj)
        {
            while (ClientAutoSendThread != null && TcpTestClient.IsRunning())
            {
                string dtNow = DateTime.Now.ToString("HH:mm:ss.fff");
                string msg = $"[SENDING_TIME={dtNow}] " + txtClientMessage.Text;

                TcpTestClient.SendQueue(msg);
                //TcpTestClient.Send(msg);//큰차이없는듯

                Thread.Sleep(100);
            }
        }
    }
}
