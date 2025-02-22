using _INNO._Crypt;
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
    public partial class Form_01_Crypt : CustomFormVirtual
    {
        public Form_01_Crypt()
        {
            InitializeComponent();
        }

        private void Form_Load(object sender, EventArgs e)
        {
            SetPrintLogControl(lbLog);

            comboCrypt_Type.SelectedItem = "AES128(Salt)";//.SelectedIndex = 0;
            comboHash_Type.SelectedItem = "SHA256";
        }

        private void Form_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void btnCrypt_Encrypt_Click(object sender, EventArgs e)
        {
            PrintLog($"#", 100);
            PrintLog($"_Crypt._InnoCrypt 암호화/복호화 사용 예제입니다.");
            PrintLog($"#", 100);

            PrintLog($"- 암호화를 시작합니다.");
            PrintLog($"- 암호화 방식 : {comboCrypt_Type.SelectedItem.ToString()}");
            PrintLog($"- 평문 : {txtCrypt_PlainText.Text}");
            PrintLog($"- 암호 : {txtCrypt_Password.Text}");
            string pass = txtCrypt_Password.Text;
            switch (comboCrypt_Type.SelectedItem.ToString().ToUpper())
            {
                case "DES": txtCrypt_EncryptedText.Text = _InnoCrypt.DES._Encrypt(txtCrypt_PlainText.Text, pass); break;
                case "AES128": txtCrypt_EncryptedText.Text = _InnoCrypt.AES128._Encrypt(txtCrypt_PlainText.Text, pass); break;
                case "AES128(SALT)": txtCrypt_EncryptedText.Text = _InnoCrypt.AES128._EncryptSalt(txtCrypt_PlainText.Text, pass); break;
            }
            PrintLogLn($"- 암호화 완료 : {txtCrypt_EncryptedText.Text}");
        }

        private void btnCrypt_Decrypt_Click(object sender, EventArgs e)
        {
            PrintLog($"#", 100);
            PrintLog($"_Crypt._InnoCrypt 암호화/복호화 사용 예제입니다.");
            PrintLog($"#", 100);

            PrintLog($"- 복호화를 시작합니다.");
            PrintLog($"- 복호화 방식 : {comboCrypt_Type.SelectedItem.ToString()}");
            PrintLog($"- 암호문 : {txtCrypt_EncryptedText.Text}");
            PrintLog($"- 암호 : {txtCrypt_Password.Text}");
            string pass = txtCrypt_Password.Text;
            switch (comboCrypt_Type.SelectedItem.ToString().ToUpper())
            {
                case "DES": txtCrypt_DecryptedText.Text = _InnoCrypt.DES._Decrypt(txtCrypt_EncryptedText.Text, pass); break;
                case "AES128": txtCrypt_DecryptedText.Text = _InnoCrypt.AES128._Decrypt(txtCrypt_EncryptedText.Text, pass); break;
                case "AES128(SALT)": txtCrypt_DecryptedText.Text = _InnoCrypt.AES128._DecryptSalt(txtCrypt_EncryptedText.Text, pass); break;
            }
            PrintLogLn($"- 복호화 완료 : {txtCrypt_DecryptedText.Text}");
        }

        private void btnMorse_Encrypt_Click(object sender, EventArgs e)
        {
            PrintLog($"#", 100);
            PrintLog($"_Crypt._InnoCrypt 모스부호 사용 예제입니다.");
            PrintLog($"#", 100);

            PrintLog($"- 모스 부호화를 시작합니다.");
            PrintLog($"- 평문 : {txtMorse_PlainText.Text}");

            txtMorse_EncryptedText.Text = _InnoCrypt.Morse._Encoding(txtMorse_PlainText.Text);

            PrintLogLn($"- 모스 부호화 완료 : {txtMorse_EncryptedText.Text}");
        }

        private void btnMorse_Decrypt_Click(object sender, EventArgs e)
        {
            PrintLog($"#", 100);
            PrintLog($"_Crypt._InnoCrypt 모스부호 사용 예제입니다.");
            PrintLog($"#", 100);

            PrintLog($"- 모스 복호화를 시작합니다.");
            PrintLog($"- 모스부호 : {txtMorse_EncryptedText.Text}");

            txtMorse_DecryptedText.Text = _InnoCrypt.Morse._Decoding(txtMorse_EncryptedText.Text);

            PrintLogLn($"- 모스 복호화 완료 : {txtMorse_DecryptedText.Text}");
        }

        private void btnMorse_BeepPlay_Click(object sender, EventArgs e)
        {
            PrintLog($"#", 100);
            PrintLog($"_Crypt._InnoCrypt 모스부호 사용 예제입니다.");
            PrintLog($"#", 100);

            PrintLog($"- 모스 부호 소리 재생합니다.");

            //Func<string, int> func = _InnoCrypt.Morse._BeepPlay; // Func는 반환타입이 있는 것
            //Action<string, int> act = _InnoCrypt.Morse._BeepPlay; // Act는 반환타입이 void 인 것

            //InnoNameThread._Start((Action<string, int>)_InnoCrypt.Morse._BeepPlay, txtMorse_EncryptedText.Text, 1000); // 실행만
            InnoNameThread._Start("MorseBeep", (Action<string, int>)_InnoCrypt.Morse._BeepPlay, txtMorse_EncryptedText.Text, 1000);
        }

        private void btnMorse_BeepStop_Click(object sender, EventArgs e)
        {
            PrintLog($"- 모스 부호 소리 정지합니다.");

            InnoNameThread._Stop("MorseBeep");
        }

        private void btnHash_Hash_Click(object sender, EventArgs e)
        {
            PrintLog($"#", 100);
            PrintLog($"_Crypt._InnoCrypt 해시 사용 예제입니다.");
            PrintLog($"#", 100);

            PrintLog($"- 해시를 시작합니다.");
            PrintLog($"- 해시 방식 : {comboHash_Type.SelectedItem.ToString()}");
            PrintLog($"- 평문 : {txtHash_PlainText.Text}");
            switch (comboHash_Type.SelectedItem.ToString().ToUpper())
            {
                case "MD5": txtHash_HashText.Text = _InnoCrypt.HASH.MD5._GetHash(txtHash_PlainText.Text); break;
                case "SHA256": txtHash_HashText.Text = _InnoCrypt.HASH.SHA256._GetHash(txtHash_PlainText.Text); break;
            }
            PrintLogLn($"- 해시 완료 : {txtHash_HashText.Text}");
        }
    }
}
