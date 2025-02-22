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
    public partial class Form_99_ColorPicker : CustomFormVirtual
    {
        // 나중에 참고하여 만들면 좋을 "Just Color Picker"
        // https://annystudio.com/software/colorpicker/

        public Form_99_ColorPicker()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Form.Visible 상태에서만 동작하는 Timer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected override void TimerVisibleRefresh_Tick(object sender, EventArgs e)
        {
            Color capturedColor = colorPicker.GetCapturedColor();
            string A = capturedColor.A.ToString();
            string R = capturedColor.R.ToString();
            string G = capturedColor.G.ToString();
            string B = capturedColor.B.ToString();
            txtA.Text = A;
            txtR.Text = R;
            txtG.Text = G;
            txtB.Text = B;
            txtColorRGB.Text = $"{R}, {G}, {B}";
            lblCapturedColor.BackColor = capturedColor;
        }

        private void colorPicker_MouseDown(object sender, MouseEventArgs e)
        {
            colorPicker.StartCapture = true;
        }

        private void colorPicker_MouseUp(object sender, MouseEventArgs e)
        {
            colorPicker.StartCapture = false;
        }
    }
}
