using _INNO;
using _INNO._Custom;
using _INNO._Data;
using _INNO._File;
using _INNO._System;
using _INNO._UI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INNOexample
{
    public partial class Form_02_Data : CustomFormVirtual
    {
        public Form_02_Data()
        {
            InitializeComponent();
        }

        public Form_02_Data(string formName)
        {
            InitializeComponent();
            this.Name = formName;
        }

        private void Form_Load(object sender, EventArgs e)
        {
            SetPrintLogControl(lbLog);
            _InnoFile._CreateDirectory(@".\_Data");

            //LogManager.SetWriteFinishedCallback(WriteFinished); // 폼에서 별도 처리하고자 할때 설정 예제
        }

        private void WriteFinished(object obj)
        {
        }

        private void Form_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void btn_InnoData_Click(object sender, EventArgs e)
        {
            PrintLog("#", 100);
            PrintLog("_Data._InnoData 사용 예제입니다.");
            PrintLog("#", 100);

            PrintLog("- 1~100 까지의 아스키 문자열을 출력합니다.");
            PrintLogLn(_InnoData._GetAscii(1, 100));
        }

        private void btnInnoDictionary_Click(object sender, EventArgs e)
        {
            PrintLog("#", 100);
            PrintLog("_Data.InnoDictionary 사용 예제입니다.");
            PrintLog("#", 100);

            PrintLog("- InnoDictionary 객체를 생성하고 키/값 들을 추가합니다.");
            InnoDictionary dic = new InnoDictionary();
            dic["Key1"] = 1;
            dic["Key2"] = "Value2";
            dic.Add("Key3", 3.3);
            PrintLog($"dic[\"Key1\"] = 1; \t\t=> dic[\"Key1\"] = {dic["Key1"]}"); // 키 지정하며 추가 및 값 가져오는 방법 dic[키]
            PrintLog($"dic[\"Key2\"] = \"Value2\"; \t=> dic.Value(\"Key2\") = {dic.Value("Key2")}"); // 키 지정하며 추가 및 값 가져오는 방법 dic.Value()
            PrintLogLn($"dic.Add(\"Key3\", 3.3); \t=> dic.Object(\"Key3\") = {dic.Object("Key3")}"); // Add() 함수로 추가 및 값 가져오는 방법 dic.Object()

            PrintLog("- 값을 변경합니다.");
            dic["Key1"] = "값1";
            dic[1] = "값2";
            dic.Update("Key3", "값3");
            PrintLog($"dic[\"Key1\"] = \"값1\"; \t=> dic[\"Key1\"] = {dic[0]}"); // 키로 접근하여 변경
            PrintLog($"dic[1] = \"값2\"; \t\t=> dic.Value(\"Key2\") = {dic.Value("Key2")}"); // 인덱스로 접근하여 변경
            PrintLogLn($"dic.Update(\"Key3\", \"값3\"); \t=> dic.Object(\"Key3\") = {dic.Object("Key3")}"); // Update() 함수로 변경

            PrintLog("- Key2 앞에 Key2.5 키/값을 삽입합니다.");
            dic.Insert("Key2", "Key2.5", "값2.5");
            PrintLogLn($"dic.Insert(\"Key2\", \"Key2.5\", \"값2.5\"); \t=> dic[\"Key2.5\"] = {dic["Key2.5"]}");

            PrintLog("- Key2를 삭제합니다.");
            dic.Remove("Key2");
            PrintLogLn($"dic.Remove(\"Key2\"); \t=> dic[\"Key2\"] = {dic["Key2"]}"); // 삭제

            PrintLog("- for loop 접근입니다.");
            for (int i = 0; i < dic.Count; i++)
            {
                PrintLog($"dic[\"{dic.Key(i)}\"] = {dic[i]}");
            }
            PrintLog("");
        }

        private void btnInnoDictionarySimple_Click(object sender, EventArgs e)
        {
            PrintLog("#", 100);
            PrintLog("_Data.InnoDictionarySimple 사용 예제입니다.");
            PrintLog("#", 100);

            PrintLog("- InnoDictionarySimple 객체를 생성하고 키/값 들을 추가합니다.");
            InnoDictionarySimple dic = new InnoDictionarySimple();
            dic["Key1"] = 1;
            dic["Key2"] = "Value2";
            dic.Add("Key3", 3.3);
            PrintLog($"dic[\"Key1\"] = 1; \t\t=> dic[\"Key1\"] = {dic["Key1"]}"); // 키 지정하며 추가 및 값 가져오는 방법 dic[키]
            PrintLog($"dic[\"Key2\"] = \"Value2\"; \t=> dic.Value(\"Key2\") = {dic.Value("Key2")}"); // 키 지정하며 추가 및 값 가져오는 방법 dic.Value()
            PrintLogLn($"dic.Add(\"Key3\", 3.3); \t=> dic.Object(\"Key3\") = {dic.Object("Key3")}"); // Add() 함수로 추가 및 값 가져오는 방법 dic.Object()

            PrintLog("- 값을 변경합니다.");
            dic["Key1"] = "값1";
            dic[1] = "값2";
            dic.Update("Key3", "값3");
            PrintLog($"dic[\"Key1\"] = \"값1\"; \t=> dic[\"Key1\"] = {dic[0]}"); // 키로 접근하여 변경
            PrintLog($"dic[1] = \"값2\"; \t\t=> dic.Value(\"Key2\") = {dic.Value("Key2")}"); // 인덱스로 접근하여 변경
            PrintLogLn($"dic.Update(\"Key3\", \"값3\"); \t=> dic.Object(\"Key3\") = {dic.Object("Key3")}"); // Update() 함수로 변경

            PrintLog("- Key2 앞에 Key2.5 키/값을 삽입합니다.");
            dic.Insert("Key2", "Key2.5", "값2.5");
            PrintLogLn($"dic.Insert(\"Key2\", \"Key2.5\", \"값2.5\"); \t=> dic[\"Key2.5\"] = {dic["Key2.5"]}"); // 인덱스로 접근하여 가져오기

            PrintLog("- Key2를 삭제합니다.");
            dic.Remove("Key2");
            PrintLogLn($"dic.Remove(\"Key2\"); \t=> dic[\"Key2\"] = {dic["Key2"]}"); // 삭제

            PrintLog("- for loop 접근입니다.");
            for (int i = 0; i < dic.Count; i++)
            {
                PrintLog($"dic[\"{dic.Key(i)}\"] = {dic[i]}");
            }
            PrintLogLn();
        }

        private void btnInnoCodeManager_Click(object sender, EventArgs e)
        {
            PrintLog("#", 100);
            PrintLog("_Data.InnoCodeManager 사용 예제입니다.");
            PrintLog("- 코드들은 날짜별로 저장되어 관리되고, 사용자는 날짜 바뀜과 무관하게 유일한 코드 기반으로 사용할 수 있습니다.");
            PrintLog("#", 100);

            PrintLog("- InnoCodeManager 객체를 생성하고 설정합니다.");
            PrintLog("- ./_Data/InnoCodeManager/년/년월/년월일/CODE/코드명.txt 로 생성되며 관리됩니다.");
            PrintLog("- 최근 7일이내 폴더에 코드명.txt 파일이 있다면 새로 생성하지 않고 기존 파일을 사용합니다.");
            InnoCodeManager ct = new InnoCodeManager();
            ct.SetRootFolder(@".\_Data\InnoCodeManager");
            ct.SetSubFolder("CODE");
            ct.SetFileExtension("txt");
            ct.SetFindPastDays(7);
            string codeFile = ct.GetCodeFile("ID_001"); // 특정 코드 파일 경로를 생성하며 가져옵니다.
            PrintLogLn($"ct.GetCodeFile(\"ID_001\") \t=> {codeFile}");

            if (codeFile != null)
            {
                PrintLog("- 해당 파일에 정보를 저장하고 확인합니다.");
                InnoIni._WriteString("DATA", "CODE", ct.Code, codeFile);
                InnoIni._WriteString("DATA", "SIZE_X", "100", codeFile);
                InnoIni._WriteString("DATA", "SIZE_Y", "200", codeFile);
                InnoIni._WriteString("DATA", "INFO", "정보", codeFile);
                PrintLog($"InnoIni._WriteString(\"DATA\", \"CODE\", ct.Code, codeFile); \t=> {InnoIni._ReadString("DATA", "CODE", codeFile)}");
                PrintLog($"InnoIni._WriteString(\"DATA\", \"SIZE_X\", \"100\", codeFile); \t=> {InnoIni._ReadString("DATA", "SIZE_X", codeFile)}");
                PrintLog($"InnoIni._WriteString(\"DATA\", \"SIZE_Y\", \"200\", codeFile); \t=> {InnoIni._ReadString("DATA", "SIZE_Y", codeFile)}");
                PrintLog($"InnoIni._WriteString(\"DATA\", \"INFO\", \"정보\", codeFile); \t=> {InnoIni._ReadString("DATA", "INFO", codeFile)}");
            }
            PrintLogLn();
        }

        private void btnCustomCodeTrackerIni_Click(object sender, EventArgs e)
        {
            PrintLog("#", 100);
            PrintLog("_Custom.CustomCodeTrackerIni 사용 예제입니다.");
            PrintLog("#", 100);

            PrintLog("- CustomCodeTrackerIni 객체를 생성하고 설정합니다.");
            PrintLog("- ./_Data/CustomCodeTrackerIni/년/년월/년월일/코드명.ini 로 생성되며 관리됩니다.");
            PrintLog("- 최근 7일이내 폴더에 코드명.txt 파일이 있다면 새로 생성하지 않고 기존 파일을 사용합니다.");
            PrintLogLn();

            CustomCodeTrackerIni ct = new CustomCodeTrackerIni();

            PrintLog($"ct.IsTrackOK(\"Item_01\") = {ct.IsTrackOK("Item_01")}");
            PrintLog($"ct.IsTrackNG(\"Item_01\") = {ct.IsTrackNG("Item_01")}");
            PrintLog($"ct.IsTrackNone(\"Item_01\") = {ct.IsTrackNone("Item_01")}");
            PrintLogLn();

            PrintLog($"- OK로 설정합니다. ct.SetTrackOK(\"Item_01\");");
            ct.SetTrackOK("Item_01");

            PrintLog($"ct.IsTrackOK(\"Item_01\") = {ct.IsTrackOK("Item_01")}");
            PrintLog($"ct.IsTrackNG(\"Item_01\") = {ct.IsTrackNG("Item_01")}");
            PrintLog($"ct.IsTrackNone(\"Item_01\") = {ct.IsTrackNone("Item_01")}");
            PrintLogLn();

            PrintLog($"- 추가 정보를 추가하는 방법입니다.");
            ct["Item_01"]["SIZE"]["X"] = 800;
            ct["Item_01"]["SIZE"]["Y"] = 600;
            PrintLog($"ct[\"Item_01\"][\"SIZE\"][\"X\"] = 800; \t=> {ct["Item_01"]["SIZE"]["X"]}");
            PrintLog($"ct[\"Item_01\"][\"SIZE\"][\"Y\"] = 600; \t=> {ct["Item_01"]["SIZE"]["Y"]}");
            PrintLogLn();

            PrintLog($"- None으로 설정합니다. ct.SetTrackNone(\"Item_01\");");
            ct.SetTrackNone("Item_01");

            PrintLog($"ct.IsTrackOK(\"Item_01\") = {ct.IsTrackOK("Item_01")}");
            PrintLog($"ct.IsTrackNG(\"Item_01\") = {ct.IsTrackNG("Item_01")}");
            PrintLog($"ct.IsTrackNone(\"Item_01\") = {ct.IsTrackNone("Item_01")}");
            PrintLogLn();

            PrintLog($"- NG로 설정합니다. ct.SetTrackNG(\"Item_01\");");
            ct.SetTrackNG("Item_01");

            PrintLog($"ct.IsTrackOK(\"Item_01\") = {ct.IsTrackOK("Item_01")}");
            PrintLog($"ct.IsTrackNG(\"Item_01\") = {ct.IsTrackNG("Item_01")}");
            PrintLog($"ct.IsTrackNone(\"Item_01\") = {ct.IsTrackNone("Item_01")}");
            PrintLogLn();

            PrintLog($"- OK로 설정합니다. ct.SetTrackOK(\"Item_01\"); => 이미 NG 처리되었기 때문에 OK 처리되지 않습니다.");
            ct.SetTrackOK("Item_01");

            PrintLog($"ct.IsTrackOK(\"Item_01\") = {ct.IsTrackOK("Item_01")}");
            PrintLog($"ct.IsTrackNG(\"Item_01\") = {ct.IsTrackNG("Item_01")}");
            PrintLog($"ct.IsTrackNone(\"Item_01\") = {ct.IsTrackNone("Item_01")}");
            PrintLogLn();

            PrintLog($"- 강제 OK 설정합니다. ct.SetTrackOK(\"Item_01\", true);");
            ct.SetTrackOK("Item_01", true);

            PrintLog($"ct.IsTrackOK(\"Item_01\") = {ct.IsTrackOK("Item_01")}");
            PrintLog($"ct.IsTrackNG(\"Item_01\") = {ct.IsTrackNG("Item_01")}");
            PrintLog($"ct.IsTrackNone(\"Item_01\") = {ct.IsTrackNone("Item_01")}");

            PrintLogLn();
        }

        private void btnInnoCodeManagerIni_Click(object sender, EventArgs e)
        {
            PrintLog("#", 100);
            PrintLog("_Data.InnoCodeManagerIni 사용 예제입니다.");
            PrintLog("#", 100);

            PrintLog("- InnoCodeManagerIni 객체를 생성하고 설정합니다.");
            InnoCodeManagerIni cmIni = new InnoCodeManagerIni();
            cmIni.SetRootFolder(@".\_Data\InnoCodeManagerIni");
            cmIni.SetSubFolder("CODE");
            cmIni.SetFileExtension("ini");
            cmIni.SetFindPastDays(7);
            if (cmIni.GetCodeFile("ID_002") != null) // 특정 코드 파일 경로를 생성하며 가져옵니다.
            {
                PrintLogLn($"cmIni.CodeFile \t=> {cmIni.CodeFile}");
                PrintLog("- cmIni[코드][섹션][키] 로 접근하여 데이터를 읽고 씁니다.");
                cmIni["ID_002"]["DATA"]["CODE"] = cmIni.Code;
                cmIni["ID_002"]["DATA"]["DATETIME"] = Inno._GetNowFormatString();
                cmIni["ID_002"]["DATA"]["SIZE_X"] = 400;
                cmIni["ID_002"]["DATA"]["SIZE_Y"] = 300;
                cmIni["ID_002"]["DATA"]["INFO"] = "정보입니다.";
                PrintLog($"cmIni[\"ID_002\"][\"DATA\"][\"CODE\"] = cmIni.Code; \t=> {cmIni["ID_002"]["DATA"]["CODE"]}");
                PrintLog($"cmIni[\"ID_002\"][\"DATA\"][\"DATETIME\"] = Inno._GetNowFormatString(); \t=> {cmIni["ID_002"]["DATA"]["DATETIME"]}");
                PrintLog($"cmIni[\"ID_002\"][\"DATA\"][\"SIZE_X\"] = 400; \t\t=> {cmIni["ID_002"]["DATA"]["SIZE_X"]}");
                PrintLog($"cmIni[\"ID_002\"][\"DATA\"][\"SIZE_Y\"] = 300; \t\t=> {cmIni["ID_002"]["DATA"]["SIZE_Y"]}");
                PrintLog($"cmIni[\"ID_002\"][\"DATA\"][\"INFO\"] = \"정보입니다.\"; \t=> {cmIni["ID_002"]["DATA"]["INFO"]}");
            }
            PrintLogLn();
        }

        private void btnCustomCellManagerIni_Click(object sender, EventArgs e)
        {
            PrintLog("#", 100);
            PrintLog("_Custom.CustomCellManagerIni 사용 예제입니다.");
            PrintLog("- CellManager를 CellID 한 개당 할당하여 사용할 수 있고,");
            PrintLog("- CellID를 재할당하며 Manager를 관리하는 객체로 사용할 수 있습니다.");
            PrintLog("#", 100);

            PrintLog("- CustomCellManagerIni 객체를 생성합니다. (Cell_001 할당)");
            CustomCellManagerIni cm = new CustomCellManagerIni("Cell_001");
            PrintLog($"cm.CodeFile \t\t=> {cm.CodeFile}");
            PrintLog($"cm.Code \t\t=> {cm.Code}");
            PrintLog($"cm.ID \t\t=> {cm.ID}");
            PrintLog($"cm.DATETIME_CREATE \t=> {cm.DATETIME_CREATE}");
            PrintLog($"cm.DATETIME_LAST \t=> {cm.DATETIME_LAST}");
            PrintLogLn();

            PrintLog("- cm.프로퍼티 로 접근하여 데이터를 읽고 씁니다.");
            cm.SIZE_X = 100;
            cm.SIZE_Y = 200;
            cm.INFO = "정보";
            PrintLog($"cm.SIZE_X = 100; \t=> {cm.SIZE_X}");
            PrintLog($"cm.SIZE_Y = 200; \t=> {cm.SIZE_Y}");
            PrintLog($"cm.INFO = \"정보\"; \t=> {cm.INFO}");
            PrintLogLn();

            PrintLog("- cm.프로퍼티 로 접근하여 데이터를 수정합니다.");
            cm.SIZE_X = 800;
            cm.SIZE_Y = 600;
            cm.INFO = "정보 수정";
            PrintLog($"cm.SIZE_X = 800; \t=> {cm.SIZE_X}");
            PrintLog($"cm.SIZE_Y = 600; \t=> {cm.SIZE_Y}");
            PrintLog($"cm.INFO = \"정보 수정\"; \t=> {cm.INFO}");
            PrintLogLn();

            PrintLog("- CellManager에 새로운 Cell을 할당하여 데이터를 읽고 씁니다.");
            cm.SetCode("Cell_002"); // 새로운 CellID 할당하여 처리
            PrintLog($"cm.CodeFile \t\t=> {cm.CodeFile}");
            PrintLog($"cm.Code \t\t=> {cm.Code}");
            PrintLog($"cm.ID \t\t=> {cm.ID}");
            PrintLog($"cm.DATETIME_CREATE \t=> {cm.DATETIME_CREATE}");
            PrintLog($"cm.DATETIME_LAST \t=> {cm.DATETIME_LAST}");
            cm.SIZE_X = 300;
            cm.SIZE_Y = 400;
            cm.INFO = "Cell_002 정보 내용";
            PrintLog($"cm.SIZE_X = 300; \t\t=> {cm.SIZE_X}");
            PrintLog($"cm.SIZE_Y = 400; \t\t=> {cm.SIZE_Y}");
            PrintLog($"cm.INFO = \"Cell_002 정보 내용\"; \t=> {cm.INFO}");
            cm.INFO = "Cell_002 정보 수정";
            PrintLog($"cm.INFO = \"Cell_002 정보 수정\"; \t=> {cm.INFO}");

            PrintLogLn();
        }

        private void btnInnoQueue_Click(object sender, EventArgs e)
        {
            PrintLog("#", 100);
            PrintLog("_Data.InnoQueue 사용 예제입니다.");
            PrintLog("#", 100);

            PrintLog("- InnoQueue<string> 객체를 생성하고 데이터를 추가합니다.");
            InnoQueue<string> queue = new InnoQueue<string>(20);
            queue.SetDeleteOld(true);
            for (int i = 0; i < 26; i++)
            {
                queue.Enqueue((i + 10).ToHex().ToString()); PrintLog($"queue.Enqueue(\"{(i + 10).ToHex().ToString()}\"); \t=> queue.Count = {queue.Count} / queue.MaxSize = {queue.MaxSize}");
            }
            PrintLogLn();

            PrintLog("- Queue에서 데이터를 하나씩 추출합니다.");
            PrintLog("- Queue에서 Dequeue되며 크기가 줄기 때문에 미리 Queue 개수를 설정해두거나 queue.Count > 0 동안 동작시킵니다.");
            int queueCount = queue.Count; // 미리 설정해두기
            for (int i = 0; i < queueCount; i++)
            {
                string item = queue.Dequeue();
                PrintLog($"queue.Dequeue(); \t=> {item}");
            }
            PrintLogLn();
        }

        private void btnInnoStack_Click(object sender, EventArgs e)
        {
            PrintLog("#", 100);
            PrintLog("_Data.InnoStack 사용 예제입니다.");
            PrintLog("#", 100);

            PrintLog("- InnoStack<string> 객체를 생성하고 데이터를 추가합니다.");
            InnoStack<string> stack = new InnoStack<string>(20);
            //stack.SetDeleteLast(true);
            for (int i = 0; i < 26; i++)
            {
                stack.Push((i + 10).ToHex().ToString()); PrintLog($"stack.Push(\"{(i + 10).ToHex().ToString()}\"); \t=> stack.Count = {stack.Count} stack.MaxSize = {stack.MaxSize}");
            }
            PrintLogLn();

            PrintLog("- Stack에서 데이터를 하나씩 추출합니다.");
            PrintLog("- Stack에서 Pop되며 크기가 줄기 때문에 미리 Stack 개수를 설정해두거나 stack.Count > 0 동안 동작시킵니다.");
            for (int i = 0; 0 < stack.Count; i++) // stack.Count > 0
            {
                string item = stack.Pop();
                PrintLog($"stack.Pop(); \t=> {item}");
            }
            PrintLogLn();
        }

        private void btnInnoKeyObjects_Click(object sender, EventArgs e)
        {
            PrintLog("#", 100);
            PrintLog("_Data.InnoKeyObjects 사용 예제입니다.");
            PrintLog("#", 100);

            PrintLog("- InnoKeyObjects 객체를 생성하고 데이터를 추가하고 가져옵니다.");
            InnoKeyObjects kos = new InnoKeyObjects();
            kos.Add(new InnoKeyObject("Key01", 1.1));
            kos.Add(new InnoKeyObject("Key02", 2.2));
            kos.Add(new InnoKeyObject("Key03", "3.3"));
            kos.Add(new InnoKeyObject("Key04", "4.4"));
            kos.Add(new InnoKeyObject("Key05", 5));

            InnoKeyObject[] koArray = new InnoKeyObject[kos.Count];
            koArray[0] = kos.Get("Key01");
            koArray[1] = kos.Get("Key02");
            koArray[2] = kos.Get("Key03");
            koArray[3] = kos.Get("Key04");
            koArray[4] = kos.Get("Key05");
            PrintLog($"{koArray[0].Key} = {koArray[0].Value}");
            PrintLog($"{koArray[1].Key} = {koArray[1].Value}");
            PrintLog($"{koArray[2].Key} = {koArray[2].Value}");
            PrintLog($"{koArray[3].Key} = {koArray[3].Value}");
            PrintLog($"{koArray[4].Key} = {koArray[4].Value}");
            PrintLogLn();

            PrintLog("- for loop 접근입니다.");
            for (int i = 0; i<kos.Count; i++)
            {
                InnoKeyObject ko = kos.Get(i);
                PrintLog($"{ko.Key} = {ko.Value}");
            }
            PrintLogLn();
        }

        private void btnInnoData_Pro_Click(object sender, EventArgs e)
        {
            PrintLog("#", 100);
            PrintLog("_Data.InnoData 사용 예제입니다.");
            PrintLog("#", 100);

            InnoData data = new InnoData();

            PrintLog("- SEC1 섹션을 만들며 KEY1, KEY2, KEY3를 추가합니다.");
            if (data["SEC1"] == null) return;
            data["SEC1"]["KEY1"] = "VAL1";
            data["SEC1"]["KEY2"] = "VAL2";
            data["SEC1"]["KEY3"] = "VAL3";
            PrintLog($"data[\"SEC1\"][\"KEY1\"] = \"VAL1\"; \t=> data[\"SEC1\"][\"KEY1\"] = {data["SEC1"]["KEY1"]}");
            PrintLog($"data[\"SEC1\"][\"KEY2\"] = \"VAL2\"; \t=> data[\"SEC1\"][\"KEY2\"] = {data["SEC1"]["KEY2"]}");
            PrintLogLn($"data[\"SEC1\"][\"KEY3\"] = \"VAL3\"; \t=> data[\"SEC1\"][\"KEY3\"] = {data["SEC1"]["KEY3"]}");

            PrintLog("- SEC2 섹션을 만들며 key1, key2, key3를 추가합니다.");
            data["SEC2"]["key1"] = "val1";
            data["SEC2"]["key2"] = "val2";
            data["SEC2"]["key3"] = "val3";
            PrintLog($"data[\"SEC2\"][\"key1\"] = \"val1\"; \t=> data[\"SEC2\"][\"key1\"] = {data["SEC2"]["key1"]}");
            PrintLog($"data[\"SEC2\"][\"key2\"] = \"val2\"; \t=> data[\"SEC2\"][\"key2\"] = {data["SEC2"]["key2"]}");
            PrintLogLn($"data[\"SEC2\"][\"key3\"] = \"val3\"; \t=> data[\"SEC2\"][\"key3\"] = {data["SEC2"]["key3"]}");

            PrintLog("- SEC2 key2 앞에 key2.5 키/값을 삽입합니다.");
            data["SEC2"].Insert("key2", "key2.5", "val2.5");
            PrintLogLn($"data[\"SEC2\"].Insert(\"key2\", \"key2.5\", \"val2.5\"); \t=> data[\"SEC2\"][\"key2.5\"] = {data["SEC2"]["key2.5"]}");

            PrintLog("- SEC2의 key2를 삭제합니다.");
            data["SEC2"].Remove("key2");
            PrintLogLn($"data[\"SEC2\"].Remove(\"key2\"); \t=> data[\"SEC2\"][\"key2\"] = {data["SEC2"]["key2"]}");

            PrintLog("- for loop 접근입니다.");
            for (int i = 0; i < data.Count; i++)
            {
                PrintLog($"data[{i}] = {data[i].Name}");
                for (int j = 0; j < data[i].Count; j++)
                {
                    PrintLog($"  data[{i}][{j}] = {data[i].Key(j)}, {data[i][j]}");
                }
            }

            // Exception 발생 테스트 (인덱스 범위)
            PrintLogLn("# 인덱스 범위 벗어나는 접근 에러 예입니다. data[\"SEC1\"]?.Value(3)", "ERROR");
            string val = data["SEC1"]?.Value(3)?.ToString();
        }

        private void btnInnoDataCsv_Pro_Click(object sender, EventArgs e)
        {
            PrintLog("#", 100);
            PrintLog("_Data.InnoDataCsv 일반 CSV 사용 예제입니다.");
            PrintLog("#", 100);

            string fullPath = @".\_Data\InnoDataCsv.csv";
            PrintLog($"- InnoDataCsv 객체를 생성합니다. {fullPath}");
            InnoDataCsv csv = new InnoDataCsv();
            csv.SetSaveInformation(true);

            if (File.Exists(fullPath))
            {
                PrintLog($"- {fullPath} 파일이 존재하여 내용을 확인합니다.");
                if (csv.Open(fullPath))
                {
                    for (int r = 0; r < csv.Count; r++)
                    {
                        for (int c = 0; c < csv[r].Count; c++)
                        {
                            PrintLog($"csv[{r}][{c}] = {csv[r][c]}");
                        }
                    }
                }
            }

            PrintLogLn($"- {fullPath} 파일을 삭제합니다.");
            File.Delete(fullPath);
            csv.Clear();

            PrintLog($"- 브리프 정보를 추가합니다.");
            csv.AddBrief(";------------------------------");
            csv.AddBrief("; 파일 정보 {FILE}");
            csv.AddBrief(";------------------------------");
            csv.AddBrief("Column 1{COMMA}Column 2{COMMA}Column 3{COMMA}Column 4{COMMA}Column 5");
            csv.BriefSmartTag("{FILE}", fullPath);

            PrintLog($"- R0Cx 데이터를 추가합니다.");
            csv["R0"]["C0"] = "R0C0";
            csv["R0"]["C1"] = "R0C1";
            csv["R0"]["C2"] = "R0C2";
            csv["R0"]["C3"] = "한글,콤마,테스트";
            csv["R0"]["C4"] = "\"A,B\",\"C,D\"";

            PrintLog($"csv[\"R0\"][\"C0\"] = \"R0C0\"; \t\t\t=> csv[\"R0\"][\"C0\"] = {csv["R0"]["C0"].ToString()}");
            PrintLog($"csv[\"R0\"][\"C1\"] = \"R0C1\"; \t\t\t=> csv[\"R0\"][\"C1\"] = {csv["R0"]["C1"].ToString()}");
            PrintLog($"csv[\"R0\"][\"C2\"] = \"R0C2\"; \t\t\t=> csv[\"R0\"][\"C2\"] = {csv["R0"]["C2"].ToString()}");
            PrintLog($"csv[\"R0\"][\"C3\"] = \"한글,콤마,테스트\"; \t=> csv[\"R0\"][\"C3\"] = {csv["R0"]["C3"].ToString()}");
            PrintLog($"csv[\"R0\"][\"C4\"] = \"\"A,B\",\"C,D\"\"; \t\t=> csv[\"R0\"][\"C4\"] = {csv["R0"]["C4"].ToString()}");
            PrintLogLn();

            PrintLog($"- R1C0 ~ R2C4 데이터를 추가합니다.");
            for (int r = 1; r <= 2; r++)
            {
                for (int c = 0; c <= 4; c++)
                {
                    csv[$"R{r}"][$"C{c}"] = $"R{r}C{c}";
                    PrintLog($"csv[\"R{r}\"][\"C{c}\"] = \"R{r}C{c}\"; \t\t\t=> csv[\"R{r}\"][\"C{c}\"] = {csv[$"R{r}"][$"C{c}"].ToString()}");
                }
            }
            PrintLogLn();

            PrintLog($"- {fullPath} 파일을 저장합니다.");
            csv.SaveAs(fullPath);

            PrintLogLn();
        }

        private void btnInnoDataCsv_Pro_LangMap_Click(object sender, EventArgs e)
        {
            PrintLog("#", 100);
            PrintLog("_Data.InnoDataCsv [KEY] CSV 사용 예제입니다.");
            PrintLog("#", 100);

            string fullPath = @".\_Lang\LangMap.csv";
            if (InnoMessageBox._ShowDialog($"{fullPath} 다국어 파일 생성 예제입니다.\n진행하시겠습니까?", buttonType: MessageBoxButtons.YesNo) != DialogResult.Yes)
            {
                PrintLogLn();
                return;
            }

            if (File.Exists(fullPath))
            {
                if (InnoMessageBox._ShowDialog($@"{fullPath} 파일이 존재합니다. 삭제하고 진행하시겠습니까?", buttonType: MessageBoxButtons.YesNo) != DialogResult.Yes)
                    return;
            }

            File.Delete(fullPath);

            PrintLog($"- InnoDataCsv 객체를 생성합니다. {fullPath}");
            InnoDataCsv csv = new InnoDataCsv();

            PrintLog($"- 브리프 정보를 추가합니다.");
            csv.AddBrief($"`##############################");
            csv.AddBrief($"`# LanguageMap");
            csv.AddBrief($"`##############################");
            csv.AddBrief($"`# PROJECT: INNOexample");
            csv.AddBrief($"`# DATE: 2025.01.14");
            csv.AddBrief($"`# WRITER: (주)북스 BOOX Inc. Innosoft Co. 양승민");
            csv.AddBrief($"`# NOTE: 다국어 맵 파일");
            csv.AddBrief($"`# NOTE: 콤마(,) 쌍따옴표(\") 비사용을 권장합니다.");

            PrintLog($"- 다국어 정보를 추가합니다.");
            csv["[KEY]"]["Lang"] = "Lang";
            csv["default"]["Lang"] = "";
            csv["en"]["Lang"] = "";
            csv["[KEY]"]["FormMain`btnMenu_0"] = "FormMain`btnMenu_0";
            csv["default"]["FormMain`btnMenu_0"] = "       홈";
            csv["en"]["FormMain`btnMenu_0"] = "       HOME";
            csv["[KEY]"]["FormMain`btnMenu_19"] = "FormMain`btnMenu_19";
            csv["default"]["FormMain`btnMenu_19"] = "       정보";
            csv["en"]["FormMain`btnMenu_19"] = "       Information";

            csv["[KEY]"]["Form_01_Crypt`groupCrypt"] = "Form_01_Crypt`groupCrypt";
            csv["default"]["Form_01_Crypt`groupCrypt"] = "암호화/복호화";
            csv["en"]["Form_01_Crypt`groupCrypt"] = "Encrypt/Decrypt";
            csv["[KEY]"]["Form_01_Crypt`groupMorse"] = "Form_01_Crypt`groupMorse";
            csv["default"]["Form_01_Crypt`groupMorse"] = "모스,부호";
            csv["en"]["Form_01_Crypt`groupMorse"] = "Morse";
            csv["[KEY]"]["Form_05_Lang`groupLang"] = "Form_05_Lang`groupLang";
            csv["default"]["Form_05_Lang`groupLang"] = "다국어 설정";
            csv["en"]["Form_05_Lang`groupLang"] = "Multi-Language Setting";
            csv["[KEY]"]["Form_05_Lang`btnLangDefault"] = "Form_05_Lang`btnLangDefault";
            csv["default"]["Form_05_Lang`btnLangDefault"] = "default (한국어)";
            csv["en"]["Form_05_Lang`btnLangDefault"] = "default (Korea)";
            csv["[KEY]"]["Form_05_Lang`btnLangEn"] = "Form_05_Lang`btnLangEn";
            csv["default"]["Form_05_Lang`btnLangEn"] = "en (영어)";
            csv["en"]["Form_05_Lang`btnLangEn"] = "en (English)";
            
            if (csv.SaveAs(fullPath))
                PrintLog($"- 다국어 파일을 저장하였습니다. {fullPath}");
            else
                PrintLog($"- 다국어 파일 저장 실패하였습니다. {fullPath}");
            PrintLogLn();
        }

        private void btnInnoDataIni_Pro_Click(object sender, EventArgs e)
        {
            PrintLog("#", 100);
            PrintLog("_Data.InnoDataIni 사용 예제입니다.");
            PrintLog("#", 100);

            string fullPath = @".\_Data\InnoDataIni.ini";
            PrintLog($"- InnoDataIni 객체를 생성합니다. {fullPath}");
            InnoDataIni ini = new InnoDataIni();
            ini.SetSaveInformation(true);

            if (File.Exists(fullPath))
            {
                PrintLog($"- {fullPath} 파일이 존재하여 내용을 확인합니다.");
                if (ini.Open(fullPath))
                {
                    for (int r = 0; r < ini.Count; r++)
                    {
                        for (int c = 0; c < ini[r].Count; c++)
                        {
                            PrintLog($"ini[{r}][{c}] = {ini[r][c]}");
                        }
                    }
                }
            }

            PrintLogLn($"- {fullPath} 파일을 삭제합니다.");
            File.Delete(fullPath);
            ini.Clear();

            PrintLog($"- 브리프 정보를 추가합니다.");
            ini.AddBrief(";------------------------------");
            ini.AddBrief("; 파일 정보 {FILE}");
            ini.AddBrief(";------------------------------");
            ini.BriefSmartTag("{FILE}", fullPath);

            PrintLog($"- 섹션 S0 데이터를 추가합니다.");
            ini["S0"]["K0"] = "S0K0";
            ini["S0"]["K1"] = "S0K1";
            ini["S0"]["K2"] = "S0K2";
            ini["S0"]["K3"] = "한글,콤마,테스트";
            ini["S0"]["K4"] = "\"A,B\",\"C,D\"";
            PrintLog($"- ini[\"S0\"][\"K0\"] = \"S0K0\"; \t\t\t=> ini[\"S0\"][\"K0\"] = {ini["S0"]["K0"]}");
            PrintLog($"- ini[\"S0\"][\"K1\"] = \"S0K1\"; \t\t\t=> ini[\"S0\"][\"K1\"] = {ini["S0"]["K1"]}");
            PrintLog($"- ini[\"S0\"][\"K2\"] = \"S0K2\"; \t\t\t=> ini[\"S0\"][\"K2\"] = {ini["S0"]["K2"]}");
            PrintLog($"- ini[\"S0\"][\"K3\"] = \"한글,콤마,테스트\"; \t=> ini[\"S0\"][\"K3\"] = {ini["S0"]["K3"]}");
            PrintLog($"- ini[\"S0\"][\"K4\"] = \"\"A,B\",\"C,D\"\"; \t\t=> ini[\"S0\"][\"K4\"] = {ini["S0"]["K4"]}");

            PrintLog($"- 섹션 S1~S2, 키 K0~K4 데이터를 추가합니다.");
            for (int s = 1; s <= 2; s++)
            {
                for (int k = 0; k <= 4; k++)
                {
                    ini[$"S{s}"][$"K{k}"] = $"S{s}K{k}";
                    PrintLog($"- ini[\"S{s}\"][\"K{k}\"] = \"S{s}K{k}\"; \t\t\t=> ini[\"S{s}\"][\"K{k}\"] = {ini[$"S{s}"][$"K{k}"]}");
                }
            }

            PrintLogLn($"- {fullPath} 파일을 저장합니다.");
            ini.SaveAs(fullPath);
        }


        private void PrintLogNode(InnoNode node, int depth = 1)
        {
            string space = new string(' ', depth);

            // Node Name
            PrintLog($"{space}'- {node.Name}");

            // Key/Value 출력
            for (int i = 0; i < node.Count; i++)
            {
                PrintLog($"{space}  '- ({node.Key(i)}, {node.Value(i)})");
            }

            // Child Node
            for (int i = 0; i < node.NodeCount; i++)
            {
                PrintLogNode(node[i], depth + 2);
            }
        }

        private void btnInnoNode_Pro_Click(object sender, EventArgs e)
        {
            PrintLog("#", 100);
            PrintLog("_Data.InnoNode 사용 예제입니다.");
            PrintLog("#", 100);
            PrintLogLn();

            InnoNode node = new InnoNode("Root");

            PrintLog("- Root에 Key1, Key2를 추가합니다.");
            node.Add("Key1", "Value 1");
            node.Add("Key2", "Value 2");
            PrintLog($"node.Add(\"Key 1\", \"Value 1\"); \t=> node.Value(\"Key1\") = {node.Value("Key1")}");
            PrintLog($"node.Add(\"Key 2\", \"Value 2\"); \t=> node.Value(\"Key2\") = {node.Value("Key2")}");
            PrintLogLn();

            PrintLog("- Root - Node 1 - Node 2 - Node 3 를 만들며 Key1, Key2, Key3를 추가합니다.");
            node["Node 1"]["Node 2"]["Node 3"].Add("Key1", "Value 1");
            node["Node 1"]["Node 2"]["Node 3"].Add("Key2", "Value 2");
            node["Node 1"]["Node 2"]["Node 3"].Add("Key3", "Value 3");
            if (node["Node 1"] == null) return;
            PrintLog($"node[\"Node 1\"][\"Node 2\"][\"Node 3\"].Add(\"Key1\", \"Value 1\"); \t=> node[\"Node 1\"][\"Node 2\"][\"Node 3\"].Value(\"Key1\") = {node["Node 1"]["Node 2"]["Node 3"].Value("Key1")}");
            PrintLog($"node[\"Node 1\"][\"Node 2\"][\"Node 3\"].Add(\"Key2\", \"Value 2\"); \t=> node[\"Node 1\"][\"Node 2\"][\"Node 3\"].Value(\"Key2\") = {node["Node 1"]["Node 2"]["Node 3"].Value("Key2")}");
            PrintLog($"node[\"Node 1\"][\"Node 2\"][\"Node 3\"].Add(\"Key3\", \"Value 3\"); \t=> node[\"Node 1\"][\"Node 2\"][\"Node 3\"].Value(\"Key3\") = {node["Node 1"]["Node 2"]["Node 3"].Value("Key3")}");
            PrintLogLn();

            PrintLog("- Root - Node 1 - Node 2 - Node 4 를 만들며 Key1, Key2, Key3를 추가합니다.");
            node["Node 1"]["Node 2"]["Node 4"].Add("Key1", "Value 11");
            node["Node 1"]["Node 2"]["Node 4"].Add("Key2", "Value 22");
            node["Node 1"]["Node 2"]["Node 4"].Add("Key3", "Value 33");
            PrintLog($"node[\"Node 1\"][\"Node 2\"][\"Node 4\"].Add(\"Key1\", \"Value 11\"); \t=> node[\"Node 1\"][\"Node 2\"][\"Node 4\"].Value(\"Key1\") = {node["Node 1"]["Node 2"]["Node 4"].Value("Key1")}");
            PrintLog($"node[\"Node 1\"][\"Node 2\"][\"Node 4\"].Add(\"Key2\", \"Value 22\"); \t=> node[\"Node 1\"][\"Node 2\"][\"Node 4\"].Value(\"Key2\") = {node["Node 1"]["Node 2"]["Node 4"].Value("Key2")}");
            PrintLog($"node[\"Node 1\"][\"Node 2\"][\"Node 4\"].Add(\"Key3\", \"Value 33\"); \t=> node[\"Node 1\"][\"Node 2\"][\"Node 4\"].Value(\"Key3\") = {node["Node 1"]["Node 2"]["Node 4"].Value("Key3")}");
            PrintLogLn();

            PrintLog("- Root - Node 5 - Node 6 를 만들며 Key1, Key2, Key3를 추가합니다.");
            node["Node 5"]["Node 6"].Add("Key1", "Value 111");
            node["Node 5"]["Node 6"].Add("Key2", "Value 222");
            node["Node 5"]["Node 6"].Add("Key3", "Value 333");
            PrintLog($"node[\"Node 5\"][\"Node 6\"].Add(\"Key1\", \"Value 111\"); \t\t=> node[\"Node 5\"][\"Node 6\"].Value(\"Key1\") = {node["Node 5"]["Node 6"].Value("Key1")}");
            PrintLog($"node[\"Node 5\"][\"Node 6\"].Add(\"Key2\", \"Value 222\"); \t\t=> node[\"Node 5\"][\"Node 6\"].Value(\"Key2\") = {node["Node 5"]["Node 6"].Value("Key2")}");
            PrintLog($"node[\"Node 5\"][\"Node 6\"].Add(\"Key3\", \"Value 333\"); \t\t=> node[\"Node 5\"][\"Node 6\"].Value(\"Key3\") = {node["Node 5"]["Node 6"].Value("Key3")}");
            PrintLogLn();

            PrintLog("- Root - Node 5 - Node 6 의 Key2를 삭제합니다.");
            node["Node 5"]["Node 6"].Remove("Key2");
            PrintLog($"node[\"Node 5\"][\"Node 6\"].Remove(\"Key2\"); \t=> node[\"Node 5\"][\"Node 6\"].Value(\"Key2\") = {node["Node 5"]["Node 6"].Value("Key2")}");
            PrintLogLn();

            PrintLog("- for loop 접근입니다.");
            PrintLogNode(node);
            PrintLogLn();
        }

        class Company
        {
            public string Name = "Innosoft";
            protected string Phone = "010-3292-3892";
            //private string Email = "booxboox@naver.com";
            public string Homepage = "http://innosoft.kr";
            //static string _Test = "Hello World!";
        }

        private void btnInnoClassFieldInfo_Pro_Click(object sender, EventArgs e)
        {
            PrintLog("#", 100);
            PrintLog("_Data.InnoObjectVariable 사용 예제입니다.");
            PrintLog("#", 100);

            Company inno = new Company();

            PrintLog("- Company 클래스의 필드 이름을 얻어옵니다.");
            FieldInfo[] fis = InnoClassFieldInfo._GetFieldInfos(inno);
            for (int i = 0; i < fis.Length; i++)
            {
                PrintLog($"Company.{fis[i].Name} = {InnoClassFieldInfo._GetValue(inno, fis[i].Name)}");
            }
            PrintLogLn();

            PrintLog("- 특정 필드의 값을 얻어옵니다.");
            PrintLogLn($"Company.Name = " + InnoClassFieldInfo._GetValue(inno, "Name")?.ToString());

            PrintLog("- 특정 필드에 값을 씁니다. (주) 북스 | BOOX, Inc.");
            InnoClassFieldInfo._SetValue(inno, "Name", "(주) 북스 | BOOX, Inc.");
            PrintLogLn($"Company.Name = " + InnoClassFieldInfo._GetValue(inno, "Name")?.ToString());
        }
    }
}
