using _INNO;
using _INNO._File;
using _INNO._System;
using _INNO._Time;
using _INNO._UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INNOexample
{
    public partial class Form_13_System : CustomFormVirtual
    {
        public Form_13_System()
        {
            InitializeComponent();
        }

        private void Form_Load(object sender, EventArgs e)
        {
            SetPrintLogControl(lbLog);
            _InnoFile._CreateDirectory(@".\_System");
        }

        private void Form_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void btn_InnoSystem_Click(object sender, EventArgs e)
        {
            PrintLog("#", 100);
            PrintLog("_System._InnoSystem 사용 예제입니다.");
            PrintLog("#", 100);

            PrintLog("- 시스템 정보를 가져옵니다.");
            PrintLog($"_InnoSystem._GetUniqueComputerId() = {_InnoSystem._GetUniqueComputerId()}");
            PrintLog($"_InnoSystem._GetBiosSerialNumber() = {_InnoSystem._GetBiosSerialNumber()}");
            PrintLog($"_InnoSystem._GetMainBoardSerialNumber() = {_InnoSystem._GetMainBoardSerialNumber()}");
            PrintLog($"_InnoSystem._GetHardDiskSerialNumber() = {_InnoSystem._GetHardDiskSerialNumber().Join(" ")}");
            PrintLog($"_InnoSystem._GetUsbSerialNumber() = {_InnoSystem._GetUsbSerialNumber().Join(" ")}");
            PrintLog($"");
            PrintLog("- _INNO.dll 정보를 가져옵니다.");
            PrintLog($"_InnoSystem._GetDllLocation() = {_InnoSystem._GetDllLocation()}");
            PrintLog($"_InnoSystem._GetDllName() = {_InnoSystem._GetDllName()}");
            PrintLog($"_InnoSystem._GetDllFileVersion() = {_InnoSystem._GetDllFileVersion()}");
            PrintLog($"_InnoSystem._GetDllBuildDateTimeStandard() = {_InnoSystem._GetDllBuildDateTimeStandard()}");
            PrintLog($"_InnoSystem._GetDllBuildDateTime() = {_InnoSystem._GetDllBuildDateTime().ToString()}");
            PrintLog($"_InnoSystem._GetDllBuildDateTime_FormatString() = {_InnoSystem._GetDllBuildDateTime_FormatString()}");
            PrintLog($"");
            PrintLog("- 현재 실행파일 정보를 가져옵니다.");
            PrintLog($"_InnoSystem._GetExeLocation() = {_InnoSystem._GetExeLocation()}");
            PrintLog($"_InnoSystem._GetExeFullPath() = {_InnoSystem._GetExeFullPath()}");
            PrintLog($"_InnoSystem._GetExePath() = {_InnoSystem._GetExePath()}");
            PrintLog($"_InnoSystem._GetExeName() = {_InnoSystem._GetExeName()}");
            PrintLog($"_InnoSystem._GetExeFileVersion() = {_InnoSystem._GetExeFileVersion()}");
            PrintLog($"_InnoSystem._GetExeBuildDateTimeStandard() = {_InnoSystem._GetExeBuildDateTimeStandard()}");
            PrintLog($"_InnoSystem._GetExeBuildDateTime() = {_InnoSystem._GetExeBuildDateTime().ToString()}");
            PrintLog($"_InnoSystem._GetExeBuildDateTime_FormatString() = {_InnoSystem._GetExeBuildDateTime_FormatString()}");
            PrintLog($"");
            PrintLog("- 프로세스 제어");
            PrintLog($"- _InnoSystem._ExecuteProcess(\"notepad\"); 프로세스 실행");
            _InnoSystem._ExecuteProcess("notepad");
            PrintLog($"- 3초 대기");
            _InnoTime._Sleep(3000);
            //{ InnoTime iTime = new InnoTime(); while (iTime.RunTime(3000)) ; }
            PrintLog($"- _InnoSystem._CheckProcessRunning(\"notepad\") = {_InnoSystem._CheckProcessRunning("notepad").ToString()}");
            //{ InnoTime iTime = new InnoTime(); while (iTime.RunTime(2000)) ; }
            PrintLog($"- _InnoSystem._KillProcess(\"notepad\"); 프로세스 종료");
            _InnoSystem._KillProcess("notepad");
            PrintLog($"- 2초 대기");
            _InnoTime._Sleep(2000);
            PrintLog($"- _InnoSystem._CheckProcessRunning(\"notepad\") = {_InnoSystem._CheckProcessRunning("notepad").ToString()}");
            PrintLog($"");
        }

        private void btnInnoSystemRegistry_Click(object sender, EventArgs e)
        {
            if (!Inno._IsAdministrator())
            {
                InnoMessageBox msgBox = new InnoMessageBox();
                msgBox.SetSize(new Size(300, 200));
                DialogResult dResult = msgBox.ShowDialog("관리자 권한으로 실행되어야 합니다.\n관리자 권한으로 실행할까요?", "관리자 권한", System.Windows.Forms.MessageBoxButtons.YesNo);
                if (dResult == DialogResult.Yes)
                {
                    Inno._RunAsAdministrator();
                }
            }
            else
                InnoRegistry._WriteString(@"Innosoft\Test", "", "Hello World!!!");
        }
    }
}
