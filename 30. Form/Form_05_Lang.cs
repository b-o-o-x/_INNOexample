using _INNO._File;
using _INNO._UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INNOexample
{
    public partial class Form_05_Lang : CustomFormVirtual
    {
        public Form_05_Lang()
        {
            InitializeComponent();
        }

        public Form_05_Lang(string formName)
        {
            InitializeComponent();
            this.Name = formName;
        }

        private void Form_Load(object sender, EventArgs e)
        {
            SetPrintLogControl(lbLog);
            _InnoFile._CreateDirectory(@".\_Lang");

            string lang = _G._Lang.Language();
            switch (lang)
            {
                case "default": btnLangDefault.Checked = true; break;
                case "en": btnLangEn.Checked = true; break;
            }

            PrintLogLn($"현재 설정된 다국어는 {lang}입니다.");
        }

        private void Form_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void btnLangDefault_Click(object sender, EventArgs e)
        {
            string fullPath = @".\_Lang\LangMap.csv";
            if (!File.Exists(fullPath))
            {
                InnoMessageBox._ShowDialog($"{fullPath} 다국어 파일이 존재하지 않습니다.\n\n- [2. _Data] - [InnoDataCsv (Pro)]를 클릭 다국어 파일을 생성하고 진행하십시오.", alignment: ContentAlignment.MiddleLeft);
                return;
            }

            PrintLogLn($"다국어 default 로 변경합니다.");
            _G._Lang.Change();
        }

        private void btnLangEn_Click(object sender, EventArgs e)
        {
            string fullPath = @".\_Lang\LangMap.csv";
            if (!File.Exists(fullPath))
            {
                InnoMessageBox._ShowDialog($"{fullPath} 다국어 파일이 존재하지 않습니다.\n\n- [2. _Data] - [InnoDataCsv (Pro)]를 클릭 다국어 파일을 생성하고 진행하십시오.", alignment: ContentAlignment.MiddleLeft);
                return;
            }

            PrintLogLn($"다국어 en 으로 변경합니다.");
            _G._Lang.Change("en");
        }
    }
}
