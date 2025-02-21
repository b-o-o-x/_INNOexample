using _INNO;
using _INNO._Custom;
using _INNO._Data;
using _INNO._File;
using _INNO._System;
using _INNO._UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INNOexample
{
    public partial class Form_04_File : CustomFormVirtual
    {
        public Form_04_File()
        {
            InitializeComponent();
        }

        private void Form_Load(object sender, EventArgs e)
        {
            SetPrintLogControl(lbLog);
            _InnoFile._CreateDirectory(@".\_File");
        }

        private void Form_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void btn_InnoFile_Click(object sender, EventArgs e)
        {
            PrintLog("#", 100);
            PrintLog("_File._InnoFile 사용 예제입니다.");
            PrintLog("#", 100);

            PrintLogLn($"_InnoFile._IsFileLocked(@\".\\_Data\\InnoDataCsv.csv\") = {_InnoFile._IsFileLocked(@".\_Data\InnoDataCsv.csv").ToString()}");

            _InnoFile._WriteTextFile(@".\Data\_InnoFile.txt", "TEST 1");
            _InnoFile._AppendTextFile(@".\Data\_InnoFile.txt", "한글");
            _InnoFile._AppendTextFile(@".\Data\_InnoFile.txt", "TEST 2");
            _InnoFile._AppendTextFile(@".\Data\_InnoFile.txt", "TEST 3");
            _InnoFile._AppendTextFileFirst(@".\Data\_InnoFile.txt", "한글 첫줄??");

            _InnoFile._GetFolderList();
            _InnoFile._GetFileList();
            _InnoFile._CreateDirectory(@".\_Test");
            _InnoFile._DeleteDirectory(@".\_Test");
            _InnoFile._CopyDirectory(@".\Test", @".\Test2");
            _InnoFile._GetRunningPath();
            _InnoFile._GetRunningPathFileName();
            _InnoFile._GetWorkingPath();

            PrintLog($"_InnoFile._ReadTextFile(@\".\\_Data\\_InnoFile.txt\") = {_InnoFile._ReadTextFile(@".\_Data\_InnoFile.txt")}");
            PrintLog($"_InnoFile._GetSearchedLineCount(@\".\\_Data\\_InnoFile.txt\", \"TEST\") = {_InnoFile._GetSearchedLineCount(@".\_Data\_InnoFile.txt", "TEST")}");
            PrintLog($"_InnoFile._GetSearchedLineArray(@\".\\_Data\\_InnoFile.txt\", \"한글\") = {_InnoFile._GetSearchedLineArray(@".\_Data\_InnoFile.txt", "한글")}");

            PrintLogLn();
        }

        private void btnInnoIni_Click(object sender, EventArgs e)
        {
            // INI 파일이 ANSI나 UTF8이면 정상 동작하며, UTF8(BOM)이면 정상적으로 읽지 못 합니다. (윈도우 Ini 제공 기능상 그러합니다.)

            PrintLog("");
            PrintLog("//----------------------------------------------------------------------");
            PrintLog("//## InnoIni 사용 예제 ([SECTION] KEY = VALUE ` COMMENT 구조)");
            PrintLog("//----------------------------------------------------------------------");
            PrintLog("");

            //## TestIni.ini 작성 예제
            string fullPath = @".\_File\InnoIni.ini";
            PrintLog($"- {fullPath} 파일을 생성하고 테스트 값을 쓰고 읽습니다.");
            InnoIni ini = new InnoIni(fullPath);
            ini.SetEncodingWrite(Encoding.Default); // ANSI로 설정
            ini.SetSaveInformation(false);

            // Ini 파일 삭제
            ini.DeleteFile();

            // Ini 주석 작성
            ini.Writeln("`-------------------");
            ini.Writeln("` InnoIni.ini 주석");
            ini.Writeln("`-------------------");

            // Ini 데이터 추가
            for (int i = 0; i < 5; i++)
            {
                ini.WriteString("S" + (i + 1), "K1", "V1");
                ini.WriteString("S" + (i + 1), "K2", "V2", "V2 값의 설명");
                ini.WriteInt32("S" + (i + 1), "K3", 333);
                ini.WriteDouble("S" + (i + 1), "K4", 123.4567890123);
            }

            // Ini 읽어오기
            PrintLog($"ini.WriteString(\"S\" + (i + 1), \"K1\", \"V1\"); \t\t=> {ini.ReadString("S1", "K1")}");
            PrintLog($"ini.WriteString(\"S\" + (i + 1), \"K2\", \"V2\", \"V2 값의 설명\"); \t=> {ini.ReadString("S1", "K2")}");
            PrintLog($"ini.WriteString(\"S\" + (i + 1), \"K2\", \"V2\", \"V2 값의 설명\"); \t=> {ini.ReadComment("S1", "K2")}");
            PrintLog($"ini.WriteInt32(\"S\" + (i + 1), \"K3\", 333); \t\t=> {ini.ReadInt32("S1", "K3").ToString()}");
            PrintLog($"ini.WriteDouble(\"S\" + (i + 1), \"K4\", 123.4567890123); \t=> {ini.ReadDouble("S1", "K4").ToString()}");
            PrintLog("----------");

            // Ini 섹션, 키 삭제
            ini.DeleteSection("S3");
            ini.DeleteKey("S4", "K3");

            // ReadSectionList()로 모든 [섹션] 정보 얻기
            PrintLog("- for loop 접근");
            PrintLog($"ini.GetSectionCount() = {ini.GetSectionCount().ToString()}");
            string[] secs = ini.ReadSectionList();
            for (int i = 0; i < secs?.Count(); i++)
            {
                PrintLog($"  secs[{i}] = {secs[i]}");

                // ReadKeyList()로 특정 [섹션]내의 모든 키 정보 얻기
                PrintLog($"  ini.GetKeyCount(secs[{i}]) = {ini.GetKeyCount(secs[i]).ToString()}");
                string[] keys = ini.ReadKeyList(secs[i]);
                for (int j = 0; j < keys.Count(); j++)
                {
                    PrintLog($"    keys[{j}] = ini.ReadString(secs[{i}], keys[{j}]) \t=> {keys[j]} = {ini.ReadString(secs[i], keys[j])}");
                }
            }
            PrintLogLn("----------");
        }

        private void btnCustomIni_Click(object sender, EventArgs e)
        {
            PrintLog("#", 100);
            PrintLog(@"/10. Custom/CustomIni.cs 사용 예제입니다.");
            PrintLog(@"* 이러한 방식으로 고객맞춤형 Ini 클래스를 제작할 수 있습니다.");
            PrintLog("#", 100);

            string fullPath = @".\_File\CustomIni.ini";
            PrintLog($"- {fullPath} 파일을 생성하고 테스트 값을 쓰고 읽습니다.");
            CustomIni ini = new CustomIni(fullPath);
            ini.SetSection("TestSection");
            ini.WriteString("TestKey", "TestValue");
            PrintLog(@"- ini.SetSection(""TestSection"");");
            PrintLog(@"- ini.WriteString(""TestKey"", ""TestValue"");");

            PrintLog($"- {fullPath} 파일의 내용을 읽어옵니다.");
            PrintLog($"- ini.ReadString(\"TestKey\") = {ini.ReadString("TestKey")}");

            PrintLogLn("");
        }

        private void btnInnoCsv_Click(object sender, EventArgs e)
        {
            PrintLog("#", 100);
            PrintLog("_File.InnoCsv 사용 예제입니다.");
            PrintLog("#", 100);

            string fullPath = @".\_File\InnoCsv.csv";
            PrintLog($"- {fullPath} 파일을 생성하고 테스트 값을 쓰고 읽습니다.");
            InnoCsv csv = new InnoCsv();
            csv.SetFullPath(fullPath);
            csv.SetSaveInformation(true);
            string[,] data1_1 = new string[,] {
                {"r0c0 (x0y0)", "r0c1 (x1y0)", "r0c2 (x2y0)", "r0c3 (x3y0)"},
                {"r1c0 (x0y1)", "r1c1 (x1y1)", "r1c2 (x2y1)", "r1c3 (x3y1)"},
                {"r2c0 (x0y2)", "r2c1 (x1y2)", "r2c2 (x2y2)", "r2c3 (x3y2)"},
            };
            csv.Write(data1_1);

            PrintLog($"{fullPath} 파일의 내용을 읽어옵니다.");
            string[,] data1_2 = csv.Read();
            PrintLog(data1_2.ToDisplayString());
            //InnoMessageBox._ShowDialog(data1_2.ToArrayString());


            fullPath = @".\_File\InnoCsv2.csv";
            PrintLog($"");
            PrintLog($"//----------------------------------------------------------------------");
            PrintLog($"//## InnoCsv 사용 예제 - {fullPath} 파일에 데이터를 쓰고 읽어옵니다.");
            PrintLog($"//----------------------------------------------------------------------");
            PrintLog($"");
            PrintLog($"- {fullPath} 파일을 생성하고 테스트 값을 쓰고 읽습니다.");

            InnoCsv csv2 = new InnoCsv();
            csv2.SetFullPath(fullPath);

            // 기존 파일 삭제하고 재생성시 사용. (데이터를 누적 추가하는 경우에는 사용하지 말 것.)
            if (csv2.IsExists())
            {
                PrintLog(@"InnoCsv2.csv 파일이 존재하는 경우 삭제합니다.");
                csv2.DeleteFile();

                // Column 필요시
                PrintLog(@"InnoCsv2.csv 파일에 Column1,Column2,Column3 를 씁니다. (칼럼 필요시 사용)");
                csv2.Writeln("Column1,Column2,Column3");
            }

            // Data
            PrintLog(@"InnoCsv2.csv 파일에 데이터를 씁니다.");
            csv2.Writeln("안,녕,하세요");
            csv2.Writeln("반,갑,습니다");
            csv2.Writeln("행,복,하세요");

            // Read All
            PrintLog(@"InnoCsv2.csv 파일에서 전체 데이터를 읽어옵니다.");
            string[][] data2 = csv2.ReadArrays();
            for (int x = 0; x < data2.Length; x++)
            {
                for (int y = 0; y < data2[x].Length; y++)
                {
                    PrintLog($"data[{x}][{y}] = {data2[x][y]}");
                }
            }

            PrintLog(@"-", 100);
        }

        private void btnInnoIni_Pro_Click(object sender, EventArgs e)
        {
            PrintLog("#", 100);
            PrintLog(@"_File.InnoIni 사용 예제입니다.");
            PrintLog("#", 100);

            string fullPath = @".\_File\InnoIni(Pro).ini";
            PrintLog($"- {fullPath} 다음과 같은 방식으로 쉽게 데이터를 읽고 쓸 수 있습니다.");
            InnoIni ini = new InnoIni(fullPath);
            if (ini["SEC1"] == null) return;
            ini["SEC1"]["KEY1"] = "Value 1-1";
            ini["SEC1"]["KEY2"] = 123.456;
            ini["SEC1"]["KEY3"] = true;
            ini["SEC2"]["KEY1"] = "Value 2-1";
            ini["SEC3"]["TEST"] = "TEST Value";
            PrintLog($"ini[\"SEC1\"][\"KEY1\"] = \"Value 1-1\"; \t=> {ini["SEC1"]["KEY1"].ToString()}");
            PrintLog($"ini[\"SEC1\"][\"KEY2\"] = 123.456; \t=> {ini["SEC1"]["KEY2"].ToString()}");
            PrintLog($"ini[\"SEC1\"][\"KEY3\"] = true; \t=> {ini["SEC1"]["KEY3"].ToString()}");
            PrintLog($"ini[\"SEC2\"][\"KEY1\"] = \"Value 2-1\"; \t=> {ini["SEC2"]["KEY1"].ToString()}");
            PrintLog($"ini[\"SEC3\"][\"TEST\"] = \"TEST Value\"; \t=> {ini["SEC3"]["TEST"].ToString()}");

            PrintLog(@"- 데이터를 변경합니다.");
            ini["SEC1"]["KEY1"] = 987.321;
            ini["SEC1"]["KEY2"] = "Value 1-2";
            ini["SEC1"]["KEY3"] = false;
            ini["SEC2"]["KEY1"] = "Value 2-1 변경됨";
            ini["SEC3"]["TEST"] = "테스트 값입니다. `주석";
            PrintLog($"ini[\"SEC1\"][\"KEY1\"] = 987.321; \t\t=> {ini["SEC1"]["KEY1"].ToString()}");
            PrintLog($"ini[\"SEC1\"][\"KEY2\"] = \"Value 1-2\"; \t\t=> {ini["SEC1"]["KEY2"].ToString()}");
            PrintLog($"ini[\"SEC1\"][\"KEY3\"] = false; \t\t=> {ini["SEC1"]["KEY3"].ToString()}");
            PrintLog($"ini[\"SEC2\"][\"KEY1\"] = \"Value 2-1 변경됨\"; \t=> {ini["SEC2"]["KEY1"].ToString()}");
            PrintLog($"ini[\"SEC3\"][\"TEST\"] = \"테스트 값 `주석\"; \t=> {ini["SEC3"]["TEST"].ToString()}");

            PrintLog(@"- 주석만 쓰기입니다.");
            ini["SEC3"].WriteComment("TEST", "테스트 주석");
            PrintLog($"ini[\"SEC3\"].WriteComment(\"TEST\", \"테스트 주석\"); \t=> {ini["SEC3"].ReadComment("TEST")}");

            PrintLog(@"- for loop 접근");
            for (int i = 0; i < ini.GetSectionCount(); i++)
            {
                for (int j = 0; j < ini[i].GetKeyCount(); j++)
                {
                    PrintLog($"ini[{i}][{j}] = {ini[i][j]}");
                }
            }

            PrintLogLn();
        }

        private void btnInnoLog_Click(object sender, EventArgs e)
        {

        }

        private void btnInnoLogManager_Click(object sender, EventArgs e)
        {

        }

        private void btnInnoLogThread_Click(object sender, EventArgs e)
        {

        }

        private void btnInnoXml_Click(object sender, EventArgs e)
        {

        }

        private void btnInnoZip_Click(object sender, EventArgs e)
        {

        }
    }
}
