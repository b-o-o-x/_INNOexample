using _INNO;
using _INNO._File;
using _INNO._Net;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INNOexample
{
    public partial class Form_09_Net : CustomFormVirtual
    {
        Form_TcpSample formTcpSample = null;

        public Form_09_Net()
        {
            InitializeComponent();
        }

        public Form_09_Net(string formName)
        {
            InitializeComponent();
            this.Name = formName;
        }

        private void Form_Load(object sender, EventArgs e)
        {
            SetPrintLogControl(lbLog);
            _InnoFile._CreateDirectory(@".\_Net");
        }

        private void Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (formTcpSample != null)
            {
                formTcpSample.Close();
            }
        }

        private void btn_InnoNet_Click(object sender, EventArgs e)
        {
            PrintLog("#", 100);
            PrintLog("_Net._InnoNet 사용 예제입니다.");
            PrintLog("#", 100);

            PrintLog($"_InnoNet._GetLocalIP(); \t\t\t=> {_InnoNet._GetLocalIP()}");
            PrintLog($"_InnoNet._GetPublicIP(); \t\t\t=> {_InnoNet._GetPublicIP()}");
            PrintLog($"_InnoNet._GetMacAddress(); \t\t=> {_InnoNet._GetMacAddress()}");
            PrintLog($"_InnoNet._GetMacAddressLargeUsage(); \t=> {_InnoNet._GetMacAddressLargeUsage()}");
            PrintLog($"_InnoNet._GetMacAddressList(); \t\t=> {_InnoNet._GetMacAddressList().ToArray().ToDisplayString()}");

            PrintLogLn();
        }

        private void btnInnoTcpTester_Click(object sender, EventArgs e)
        {
            PrintLog("#", 100);
            PrintLog("_Net.InnoTcpSample 사용 예제입니다.");
            PrintLog("#", 100);

            if (formTcpSample == null)
            {
                formTcpSample = new Form_TcpSample();
                formTcpSample.Show();
            }
            else if (!formTcpSample.Visible)
            {
                formTcpSample.Close();
                formTcpSample = new Form_TcpSample();
                formTcpSample.Show();
            }

            PrintLogLn();
        }
    }
}
