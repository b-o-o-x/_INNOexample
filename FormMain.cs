using System;
using System.Collections.Generic;
using System.Windows.Forms;
using _INNO;
using _INNO._System;
using _INNO._UI;

namespace INNOexample
{
    public partial class FormMain : CustomFormVirtual
    {
        InnoSampleMenuSlide _SampleForm = new InnoSampleMenuSlide();
        InnoToolTip toolTip = new InnoToolTip();

        public FormMain()
        {
            InitializeComponent();
        }

        // 모든 컨트롤 더블버퍼링 설정
        public static void SetDoubleBufferedAllControls(Control control)
        {
            foreach (Control c in InnoUI._GetAllControls(control))
            {
                InnoUI._SetDoubleBuffered(c);
                SetDoubleBufferedAllControls(c);
            }
        }

        private void Form_Load(object sender, EventArgs e)
        {
            SetDoubleBufferedAllControls(this);

            //ShowInTaskbar = false;
            //WindowState = FormWindowState.Minimized;

            this.Text = _InnoSystem._GetExeBuildDateTimeStandard();

            // _SampleForm 설정
            _SampleForm.FireNotifyEvent += _SampleForm_FireNotifyEvent;

            _SampleForm.SetMenuContainer(pnlMenuContainer, InnoSampleMenuSlide.eMenuSizeState.MaximumSize);
            _SampleForm.SetLogoMenu(picMenuBooxLogo);
            _SampleForm.SetLogoBg(picBooxLogo);
            _SampleForm.SetCopyRight(lblCopyRight, false);
            _SampleForm.AddForm(new Form_00(), pnlForm, pnlMenuSel_0);
            _SampleForm.AddForm(new Form_01_Crypt(), pnlForm, pnlMenuSel_1);
            _SampleForm.AddForm(new Form_02_Data(), pnlForm, pnlMenuSel_2);
            _SampleForm.AddForm(new Form_03_Dev(), pnlForm, pnlMenuSel_3);
            _SampleForm.AddForm(new Form_04_File(), pnlForm, pnlMenuSel_4);
            _SampleForm.AddForm(new Form_05_Lang(), pnlForm, pnlMenuSel_5);
            _SampleForm.AddForm(new Form_06_Machine(), pnlForm, pnlMenuSel_6);
            _SampleForm.AddForm(new Form_07_Math(), pnlForm, pnlMenuSel_7);
            _SampleForm.AddForm(new Form_08_Media(), pnlForm, pnlMenuSel_8);
            _SampleForm.AddForm(new Form_09_Net(), pnlForm, pnlMenuSel_9);
            _SampleForm.AddForm(new Form_10_Pattern(), pnlForm, pnlMenuSel_10);
            _SampleForm.AddForm(new Form_11_Security(), pnlForm, pnlMenuSel_11);
            _SampleForm.AddForm(new Form_12_Shape(), pnlForm, pnlMenuSel_12);
            _SampleForm.AddForm(new Form_13_System(), pnlForm, pnlMenuSel_13);
            _SampleForm.AddForm(new Form_14_Thread(), pnlForm, pnlMenuSel_14);
            _SampleForm.AddForm(new Form_15_Time(), pnlForm, pnlMenuSel_15);
            _SampleForm.AddForm(new Form_16_UI(), pnlForm, pnlMenuSel_16);
            _SampleForm.AddForm(new Form_17_UI_Form(), pnlForm, pnlMenuSel_17);
            _SampleForm.AddForm(new Form_INNO(), pnlForm, pnlMenuSel_18);
            _SampleForm.AddForm(new Form_Information(), pnlForm, pnlMenuSel_19);

            // 버튼 ToolTip
            Button[] btnMenus = {btnMenu_0, btnMenu_1, btnMenu_2, btnMenu_3, btnMenu_4,
                                btnMenu_5, btnMenu_6, btnMenu_7, btnMenu_8, btnMenu_9,
                                btnMenu_10, btnMenu_11, btnMenu_12, btnMenu_13, btnMenu_14,
                                btnMenu_15, btnMenu_16, btnMenu_17, btnMenu_18, btnMenu_19, };
            for (int i = 0; i < btnMenus.Length; i++)
            {
                toolTip.SetToolTip(btnMenus[i], btnMenus[i].Text);
            }

            // 시작 후, 5초동안 깜빡임
            this.Invoke(new MethodInvoker(delegate ()
            {
                InnoFlashWindow.Flash(this, 5);
            }
            ));
        }

        private void _SampleForm_FireNotifyEvent(object sender, EventArgs e)
        {
            InnoSampleMenuSlide.NotifyEventArgs ne = e as InnoSampleMenuSlide.NotifyEventArgs;
            if (ne.Data.ToUpper() == "MENU_MINIMIZED")
            {
                pnlMenuContainer.AutoScroll = false;
            }
            else if (ne.Data.ToUpper() == "MENU_MAXIMIZED")
            {
                pnlMenuContainer.AutoScroll = false;
                pnlMenuContainer.HorizontalScroll.Maximum = pnlMenuContainer.Width;
                pnlMenuContainer.HorizontalScroll.Enabled = false;
                pnlMenuContainer.HorizontalScroll.Visible = false;
                pnlMenuContainer.AutoScroll = true;
            }
        }

        private void Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            _SampleForm.FireNotifyEvent -= _SampleForm_FireNotifyEvent;

            if (_SampleForm.GetAllForm().Count > 0)
            {
                _SampleForm.CloseAllForm();

                e.Cancel = true;
                InnoUI.FormFadeOutClose(this);
            }
        }

        private void btnMenu_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) _SampleForm.SetMenuSliding(false);
            else _SampleForm.SetMenuSliding(true);
            _SampleForm.StartMenuSlide();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            string btnName = btn.Text; // btnMenu_0 ~

            int btnNo = 0;
            if (btn.Name.IndexOf("_") >= 0 && btn.Name.WordCount("_") >= 2)
            {
                btnNo = btn.Name.Split('_')[1].ToInt32();
            }
            _SampleForm.ShowForm(btnNo);
        }

        private void timerRefresh_Tick(object sender, EventArgs e)
        {
            string txt = this.Text;
            if (0 <= txt.IndexOf("`") && txt.WordCount("`") == 2)
                txt = txt.Split('`')[0];
            this.Text = txt + $"`[{Inno._LicenseState()}]";
            //this.Text = InnoSystem.GetExeBuildDateTimeStandard() + $"`[{Inno._LicenseState()}]";
        }
    }
}
