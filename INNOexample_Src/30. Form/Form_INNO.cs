using _INNO._Data;
using _INNO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _INNO._UI;

namespace INNOexample
{
    public partial class Form_INNO : CustomFormVirtual
    {
        public Form_INNO()
        {
            InitializeComponent();
        }

        public Form_INNO(string formName)
        {
            InitializeComponent();
            this.Name = formName;
        }

        private void Form_Load(object sender, EventArgs e)
        {
            _InnoUI._SetDoubleBuffered(lbLog);
            SetPrintLogControl(lbLog);
        }

        private void Form_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void btnInnoStaticMethod_Click(object sender, EventArgs e)
        {
            PrintLog("#", 100);
            PrintLog("_INNO.Inno static 메소드 사용 예제입니다.");
            PrintLog("#", 100);

            PrintLog($"_INNO.Inno._GetVersion() = {_INNO.Inno._GetVersion()}");
            PrintLog($"_INNO.Inno._IsAdministrator() = {_INNO.Inno._IsAdministrator().ToString()}");
            PrintLog($"_INNO.Inno._NewGuid() = {_INNO.Inno._NewGuid()}");
            _INNO.Inno._Clipboard_Copy("테스트");
            PrintLog($"_INNO.Inno._Clipboard_Copy(\"테스트\");");
            PrintLog($"_INNO.Inno._Clipboard_Paste() = {_INNO.Inno._Clipboard_Paste()}");
            PrintLog($"_INNO.Inno._GetNowFormatString(\"yyyy-MM-dd HH:mm:ss (fff)\") = {_INNO.Inno._GetNowFormatString("yyyy-MM-dd HH:mm:ss (fff)")}");
            PrintLog($"_INNO.Inno._IsKeyControlPress() = {_INNO.Inno._IsKeyControlPress().ToString()}");

            PrintLog($"_INNO.Inno. = ");
            PrintLog($"_INNO.Inno. = ");
            PrintLog($"_INNO.Inno. = ");

            PrintLogLn();
        }

        private void btnInnoExtensions_Click(object sender, EventArgs e)
        {
            PrintLog("#", 100);
            PrintLog("_INNO.Inno 확장 사용 예제입니다.");
            PrintLog("#", 100);

            PrintLog("- 자주 사용하는 확장");
            PrintLog($"(123).ToString() \t\t=> {(123).ToString()}");
            PrintLog($"(false).ToString() \t=> {(false).ToString()}");
            PrintLog($"(123.456).ToString() \t=> {(123.456).ToString()}");
            PrintLog($"\"100\".ToInt32() \t\t=> {"100".ToInt32().ToString()}");
            PrintLog($"\"11.22\".ToDouble() \t=> {"11.22".ToDouble().ToString()}");
            PrintLog($"\"0\".ToBool() \t\t=> {"0".ToBool().ToString()}");
            PrintLogLn($"\"false\".ToBool() \t\t=> {"false".ToBool().ToString()}");

            // byte array를 string으로 변환 예제
            PrintLog("- byte array를 string으로 변환 예제");
            byte[] b1_1 = new byte[] { 0x31, 0x32, 0x33 };
            string s1_1 = b1_1.ToAsciiString();
            string s1_2 = b1_1.ToHexString();
            string s1_3 = b1_1.ToHexString("_");
            PrintLog($"byte[] b1_1 = new byte[] {{ 0x31, 0x32, 0x33 }}; \t=> {b1_1.Flatten(", ")}");
            PrintLog($"string s1_1 = b1_1.ToAsciiString(); \t\t\t=> {s1_1}");
            PrintLog($"string s1_2 = b1_1.ToHexString(); \t\t\t=> {s1_2}");
            PrintLogLn($"string s1_3 = b1_1.ToHexString(\"_\"); \t\t\t=> {s1_3}");

            // string을 byte array로 변환 예제
            PrintLog("- string을 byte array로 변환 예제");
            string s2_1 = "333435";
            byte[] b2_1 = s2_1.ToOddByteArray();
            byte[] b2_2 = s2_1.ToByteArray();
            byte[] b2_3 = b2_1.AppendBytes(b2_2);
            byte[] b2_4 = b2_1.Combine(b2_2); // _InnoData._Combine(b2_1, b2_2);
            byte[] b2_5 = b2_1.Combine(b2_1, b2_1, b2_1, b2_1, b2_2); // _InnoData._Combine(b2_1, b2_1, b2_1, b2_1, b2_2);
            PrintLog($"string s2_1 = \"333435\"; \t\t\t\t=> {s2_1}");
            PrintLog($"byte[] b2_1 = s2_1.ToOddByteArray(); \t\t=> {b2_1.Flatten(", ")}");
            PrintLog($"byte[] b2_2 = s2_1.ToByteArray(); \t\t\t=> {b2_2.Flatten(", ")}");
            PrintLog($"byte[] b2_3 = b2_1.AppendBytes(b2_2); \t\t=> {b2_3.Flatten(", ")}");
            PrintLog($"byte[] b2_4 = _InnoData._Combine(b2_1, b2_2); \t=> {b2_4.Flatten(", ")}");
            PrintLogLn($"byte[] b2_5 = _InnoData._Combine(b2_1, b2_1, b2_1, b2_1, b2_2); \t=> {b2_5.Flatten(", ")}");

            // int를 4바이트 byte array로 변환 예제
            PrintLog("- int를 4바이트 byte array로 변환 예제");
            byte[] bytes3_1 = (134480385).To4ByteArray();
            PrintLogLn($"byte[] bytes3_1 = (134480385).To4ByteArray(); \t=> {bytes3_1.Flatten(", ")}");

            // b2_3 에서 Find 예제
            PrintLog("- b2_3 에서 Find 예제");
            int pos1 = b2_3.IndexOf(0x33);
            int pos2 = b2_3.LastIndexOf(0x33);
            int pos3 = b2_3.IndexOf(new byte[] { 0x33, 0x33 });
            int pos4 = b2_3.LastIndexOf(new byte[] { 0x33, 0x33 });
            PrintLog($"int pos1 = b2_3.IndexOf(0x33); \t\t\t=> {pos1}");
            PrintLog($"int pos2 = b2_3.LastIndexOf(0x33); \t\t\t=> {pos2}");
            PrintLog($"int pos3 = b2_3.IndexOf(new byte[] {{ 0x33, 0x33 }}); \t=> {pos3}");
            PrintLogLn($"int pos4 = b2_3.LastIndexOf(new byte[] {{ 0x33, 0x33 }}); \t=> {pos4}");

            // unicode를 ascii 문자열로 변환 예제
            PrintLog("- unicode를 ascii 문자열로 변환 예제");
            string unicodeString = "This string contains the unicode character Pi(\u03a0)";
            string asciiString = _InnoData._ConvertEncodingUnicodeToAscii(unicodeString);
            PrintLog($"string unicodeString = \"This string contains the unicode character Pi(\\u03a0)\"; \t=> {unicodeString}");
            PrintLogLn($"string asciiString = _InnoData._ConvertEncodingUnicodeToAscii(unicodeString); \t=> {asciiString}");
        }
    }
}
