using _INNO._File;
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
    public partial class Form_99_NaverEmail : CustomFormVirtual
    {
        const string INI_FILE = @".\NaverEmail.ini";
        const string INI_SECTION = "EMAIL";

        public Form_99_NaverEmail()
        {
            InitializeComponent();
        }

        private void Form_02_NaverEmail_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            if (System.IO.File.Exists(INI_FILE))
            {
                txtTo.Text = InnoIni._ReadString(INI_SECTION, "TO", INI_FILE);
                txtToName.Text = InnoIni._ReadString(INI_SECTION, "TO_NAME", INI_FILE);
                txtCc.Text = InnoIni._ReadString(INI_SECTION, "CC", INI_FILE);
                txtBcc.Text = InnoIni._ReadString(INI_SECTION, "BCC", INI_FILE);
                txtSubject.Text = InnoIni._ReadString(INI_SECTION, "SUBJECT", INI_FILE);
                txtBody.Text = InnoIni._ReadString(INI_SECTION, "BODY", INI_FILE).Replace("<br/>", "\r\n");

                txtFrom.Text = InnoIni._ReadString(INI_SECTION, "FROM", INI_FILE);
                txtFromName.Text = InnoIni._ReadString(INI_SECTION, "FROM_NAME", INI_FILE);
                string encpw = InnoIni._ReadString(INI_SECTION, "NAVER_PASSWORD", INI_FILE);
                txtNaverPassword.Text = _INNO._Crypt._InnoCrypt.DES._Decrypt(encpw);
            }
        }

        private void SaveData()
        {
            InnoIni._WriteString(INI_SECTION, "TO", txtTo.Text, INI_FILE);
            InnoIni._WriteString(INI_SECTION, "TO_NAME", txtToName.Text, INI_FILE);
            InnoIni._WriteString(INI_SECTION, "CC", txtCc.Text, INI_FILE);
            InnoIni._WriteString(INI_SECTION, "BCC", txtBcc.Text, INI_FILE);
            InnoIni._WriteString(INI_SECTION, "SUBJECT", txtSubject.Text, INI_FILE);
            InnoIni._WriteString(INI_SECTION, "BODY", txtBody.Text.Replace("\r\n", "<br/>"), INI_FILE);

            InnoIni._WriteString(INI_SECTION, "FROM", txtFrom.Text, INI_FILE);
            InnoIni._WriteString(INI_SECTION, "FROM_NAME", txtFromName.Text, INI_FILE);
            string encPw = _INNO._Crypt._InnoCrypt.DES._Encrypt(txtNaverPassword.Text);
            InnoIni._WriteString(INI_SECTION, "NAVER_PASSWORD", encPw, INI_FILE);
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> files = new List<string>();
                for (int i = 0; i < lbAttachments.Items.Count; i++)
                {
                    files.Add(lbAttachments.Items[i].ToString());
                }

                string from = txtFrom.Text;
                string fromName = txtFromName.Text;
                string to = txtTo.Text;
                string toName = txtToName.Text;
                string cc = txtCc.Text;
                string bcc = txtBcc.Text;
                string pw = txtNaverPassword.Text;
                string subject = txtSubject.Text;
                string body = txtBody.Text;

                if (_INNO._Net.InnoSMTP._SendEmailByNaver(from, fromName, to, toName,
                    cc, bcc,
                    subject, body, false, pw, files))
                {
                    _INNO._UI.InnoMessageBox._ShowDialog("메일 발송 성공");
                    SaveData();
                }
            }
            catch (Exception ex)
            {
                string msg = (ex.InnerException != null) ? ex.InnerException.ToString() : ex.ToString();
                _INNO._UI.InnoMessageBox._ShowDialog(msg);
            }
        }
    }
}
