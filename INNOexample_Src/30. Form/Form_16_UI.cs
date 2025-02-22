using _INNO._File;
using _INNO._UI;
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
    public partial class Form_16_UI : CustomFormVirtual
    {
        public Form_16_UI()
        {
            InitializeComponent();
        }

        private void Form_Load(object sender, EventArgs e)
        {
            innoUITextBox1.Click += new System.EventHandler(InnoNumPad.OnShowNumPad);

            SetPrintLogControl(lbLog);
            _InnoFile._CreateDirectory(@".\_Time");
        }

        private void Form_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void Form_VisibleChanged(object sender, EventArgs e)
        {
            if (Visible == true) timerRefresh.Start();
            else timerRefresh.Stop();
        }

        private void timerRefresh_Tick(object sender, EventArgs e)
        {
            innoUIProgressBarCircular1.Progress = _INNO._Math._InnoMath._GetRandomInt(30, 70);

            if (innoUITowerLampRYG1.IsGreenOn()) innoUITowerLampRYG1.GreenOff();
            else innoUITowerLampRYG1.GreenOn();

            if (innoUITowerLampRYGB1.IsBlueOn()) innoUITowerLampRYGB1.BlueOff();
            else innoUITowerLampRYGB1.BlueOn();
        }

        private void btnShowMsgBox_Click(object sender, EventArgs e)
        {
            string msg = "";
            for (int i = 0; i < 20; i++) msg += "긴글 테스트 입니다.\n";
            InnoMessageBox._ShowDialog(msg, "Info", MessageBoxButtons.OK, ContentAlignment.TopLeft);
        }

        private void btnShowNotifyBox_Click(object sender, EventArgs e)
        {
            InnoNotifyBox notifyBox = new InnoNotifyBox();
            notifyBox.ShowBox("테스트 알림", InnoNotifyBox.eType.OK, 3000);
        }

        private void innoUIButton1_Click(object sender, EventArgs e)
        {
            string number = InnoNumPad.ShowNumPadDialog();
            InnoMessageBox._ShowDialog(number);
        }

        private void innoUIButton2_Click(object sender, EventArgs e)
        {

        }

        private void innoUIRoundedButton1_Click(object sender, EventArgs e)
        {

        }

        static int x = 0;
        static int y = 0;
        private void innoUIButtonEllipsed1_Click(object sender, EventArgs e)
        {
            InnoMessageBox msgBox = new InnoMessageBox();
            msgBox.SetLocation(new Point(x, y));
            msgBox.StartAutoClose();
            x += 10;
            y += 10;
            if ((x + msgBox.Width) > Screen.PrimaryScreen.WorkingArea.Width ||
                (y + msgBox.Height) > Screen.PrimaryScreen.WorkingArea.Height)
            {
                x = 0;
                y = 0;
            }
            msgBox.Show("This will close within 5 seconds.");
        }
    }
}
