using _Device;
using _INNO;
using _INNO._Dev;
using _INNO._File;
using _INNO._Thread;
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
    public partial class Form_03_Dev : CustomFormVirtual
    {
        public Form_03_Dev()
        {
            InitializeComponent();
        }

        public Form_03_Dev(string formName)
        {
            InitializeComponent();
            this.Name = formName;
        }

        private void Form_Load(object sender, EventArgs e)
        {
            SetPrintLogControl(lbLog);
            _InnoFile._CreateDirectory(@".\_Dev");
        }

        private void Form_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void btnDevIFLightController_Click(object sender, EventArgs e)
        {
            DevIFLightController dev = new DevIFLightController();
            if (dev.Open("COM1"))
            {
                dev.SetOn(1);
                dev.SetLight(1, 100);
                dev.Close();
            }
        }

        protected static void loadIndicatorRecv(byte[] recvData)
        {
            string data = recvData.ToAsciiString().Substring(6, 8);

            if (Double.TryParse(data, out double d))
            {
                double val = d;
            }
        }

        private void btnDevRadianQBioIndicator_Click(object sender, EventArgs e)
        {
            DevRadianQBio_Indicator dev = new DevRadianQBio_Indicator();
            dev.SetIDNumber(1);
            if (dev.Open("COM1"))
            {
                dev.SetReceiveCallFunc(loadIndicatorRecv);
                dev.Send_SetZero();
                _InnoThread._Sleep(2000);
                dev.Close();
            }
        }

        InnoUsbCam cam = new InnoUsbCam();
        private void btnCam_Click(object sender, EventArgs e)
        {
            string btnName = (sender as Button).Name;

            switch (btnName)
            {
                case "btnCamInit": cam.Init(this, picCam); break;
                case "btnCamStart": cam.Start(); break;
                case "btnCamStop": cam.Stop();  break;
                case "btnCamDeinit": cam.Deinit(); break;
            }
        }
    }
}
