using _INNO;
using _INNO._Data;
using _INNO._File;
using _INNO._Math;
using _INNO._Thread;
using _INNO._Time;
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
using System.Xml.Linq;

namespace INNOexample
{
    public partial class Form_14_Thread : CustomFormVirtual
    {
        public Form_14_Thread()
        {
            InitializeComponent();
        }

        public Form_14_Thread(string formName)
        {
            InitializeComponent();
            this.Name = formName;
        }

        private void Form_Load(object sender, EventArgs e)
        {
            SetPrintLogControl(lbLog);
            _InnoFile._CreateDirectory(@".\_Thread");
        }

        private void Form_FormClosing(object sender, FormClosingEventArgs e)
        {

        }


        #region // _InnoThread._Start 예제입니다.
        bool InnoThread_Run = false;
        void InnoThread_Func1()
        {
            PrintLog($"InnoThread_Func1() : 스레드 시작.");
            int i = 0;
            while (InnoThread_Run)
            {
                string space = new string('*', i++ * 2);
                PrintLog($"InnoThread_Func1() : {space}");
                Thread.Sleep(100);
            }
            PrintLog($"InnoThread_Func1() : 스레드 정지.");
        }

        void InnoThread_Func2(string name, int number)
        {
            int num = number;
            PrintLog($"InnoThread_Func2({name}, {number}) : 스레드 시작.");
            while (InnoThread_Run)
            {
                string space = new string('.', num * 2);
                PrintLog($"InnoThread_Func1({name}, {number}) : {space}{num++}");
                Thread.Sleep(100);
            }
            PrintLog($"InnoThread_Func1({name}, {number}) : 스레드 정지.");
        }

        bool InnoThread_Func3()
        {
            PrintLog($"InnoThread_Func3() : 스레드 시작.");
            int i = 0;
            while (InnoThread_Run)
            {
                string space = new string('#', i++ * 2);
                PrintLog($"InnoThread_Func3() : {space}");
                Thread.Sleep(100);
            }
            PrintLog($"InnoThread_Func3() : 스레드 정지.");
            return true;
        }

        bool InnoThread_Func4(string name, int number)
        {
            int num = number;
            PrintLog($"InnoThread_Func4({name}, {number}) : 스레드 시작.");
            while (InnoThread_Run)
            {
                string space = new string('_', num * 2);
                PrintLog($"InnoThread_Func4({name}, {number}) : {space}{num++}");
                Thread.Sleep(100);
            }
            PrintLog($"InnoThread_Func4({name}, {number}) : 스레드 정지.");
            return true;
        }

        private void btn_InnoThread_Start_Click(object sender, EventArgs e)
        {
            PrintLog("#", 100);
            PrintLog("_Thread._InnoThread 정적 사용 예제입니다.");
            PrintLog("#", 100);

            PrintLog("- 스레드 4개를 시작합니다. (InnoThread_Run = true; 설정) <특성: 여러번 실행할 경우, 여러번 실행됩니다>");
            InnoThread_Run = true;
            
            _InnoThread._Start((Action)InnoThread_Func1); // 반환값 없고 패러미터 없는 메소드 호출
            _InnoThread._Start((Action<string, int>)InnoThread_Func2, "Func2", 5); // 반환값 없고 패러미터 있는 메소드 호출
            _InnoThread._Start((Func<bool>)InnoThread_Func3); // 반환값 있고 패러미터 없는 메소드 호출
            _InnoThread._Start((Func<string, int, bool>)InnoThread_Func4, "Func2", 10); // 반환값 있고 패러미터 있는 메소드 호출

            PrintLogLn();
        }

        private void btn_InnoThread_Stop_Click(object sender, EventArgs e)
        {
            PrintLog("- 스레드를 정지합니다. (InnoThread_Run = false; 설정하여 정지시킵니다.)");
            InnoThread_Run = false;

            PrintLogLn();
        }
        #endregion


        #region // BackgroundWorker 예제입니다.
        InnoThreadBackgroundWorker worker = null;

        private void BackgroundWorker_Func(DoWorkEventArgs e)
        {
            string s = e.Argument.ToString();
            PrintLog(s + " BackgroundWork Start!");
            for (int i = 0; i < 50; i++)
            {
                if (worker.CancelEvent)
                {
                    e.Cancel = true;
                    return;
                }

                worker.PauseEvent.WaitOne();

                PrintLog(s + $"{new string('_', i)}{i}");
                Thread.Sleep(100);
            }
            e.Result = "BackgroundWork Finished!!!";
        }

        private void BackgroundWorker_CompletedFunc(RunWorkerCompletedEventArgs e)
        {
            if (!e.Cancelled)
            {
                PrintLogLn(e.Result.ToString());
            }
            else
            {
                PrintLogLn("BackgroundWork Cancelled.");
            }
        }

        private void btnInnoBackgroundWorker_Start_Click(object sender, EventArgs e)
        {
            PrintLog("#", 100);
            PrintLog("_Thread.InnoBackgroundWorker 사용 예제입니다.");
            PrintLog("#", 100);

            PrintLog("- InnoBackgroundWorker 객체를 생성하고 실행합니다.");
            worker = new InnoThreadBackgroundWorker();
            worker.SetCallback(BackgroundWorker_Func);
            worker.SetCompletedCallback(BackgroundWorker_CompletedFunc);
            worker.Start("Task1");
        }

        private void btnInnoBackgroundWorker_Stop_Click(object sender, EventArgs e)
        {
            PrintLogLn("- InnoBackgroundWorker를 정지합니다.");
            worker?.Stop();
        }

        private void btnInnoBackgroundWorker_Pause_Click(object sender, EventArgs e)
        {
            PrintLogLn("- InnoBackgroundWorker를 일시정지합니다.");
            worker?.Pause();
        }

        private void btnInnoBackgroundWorker_Resume_Click(object sender, EventArgs e)
        {
            PrintLogLn("- InnoBackgroundWorker를 계속진행합니다.");
            worker?.Resume();
        }
        #endregion


        #region // InnoThreadCallback 예제입니다.
        InnoThreadCallback innoThread = new InnoThreadCallback();
        int innoThread_number = 0;

        void InnoThreadCallback_Func()
        {
            PrintLog($"{new string('|', innoThread_number)}{innoThread_number++}");
        }

        private void btnInnoThreadCallback_Start_Click(object sender, EventArgs e)
        {
            if (innoThread.IsRunning())
            {
                PrintLogLn("- 실행중인 스레드가 있습니다.");
                return;
            }
            else
            {
                PrintLog("#", 100);
                PrintLog("_Thread.InnoThreadCallback 사용 예제입니다.");
                PrintLog("#", 100);
            }

            PrintLogLn("- InnoThreadCallback 스레드를 시작합니다.");
            innoThread_number = 0;
            innoThread.SetCallback(InnoThreadCallback_Func);
            innoThread.SetDelay(100);
            innoThread.Start();
        }

        private void btnInnoThreadCallback_Stop_Click(object sender, EventArgs e)
        {
            if (!innoThread.IsRunning())
            {
                PrintLogLn("- 실행중인 스레드가 없습니다.");
                return;
            }
            else
            {
                PrintLogLn("- InnoThreadCallback 스레드를 정지합니다.");
                innoThread?.Stop();
            }
        }

        private void btnInnoThreadCallback_Pause_Click(object sender, EventArgs e)
        {
            PrintLogLn("- InnoThreadCallback 스레드를 일시정지합니다.");
            innoThread?.Pause();
        }

        private void btnInnoThreadCallback_Resume_Click(object sender, EventArgs e)
        {
            PrintLogLn("- InnoThreadCallback 스레드를 계속진행합니다.");
            innoThread?.Resume();
        }
        #endregion


        #region // InnoNameThread 예제입니다.
        void ThreadFunc1(string name, int startIndex)
        {
            int i = startIndex;

            PrintLog($"ThreadFunc1(\"{name}\", {startIndex}) : 스레드 시작.");

            string space = "";
            while (i <= 10)
            {
                space = new string('_', i * 2);
                PrintLog($"ThreadFunc1(\"{name}\", {startIndex}) : {space}{(i++).ToString()}");
                Thread.Sleep(_InnoMath._GetRandomInt(100, 1000));
            }

            PrintLogLn($"ThreadFunc1(\"{name}\", {startIndex}) : {space}스레드 종료");
        }

        int ThreadFunc2(string name, int startIndex)
        {
            int i = startIndex;

            PrintLog($"ThreadFunc2(\"{name}\", {startIndex}) : 스레드 시작.");

            string space = "";
            while (i <= 20)
            {
                space = new string('_', i * 2);
                PrintLog($"ThreadFunc2(\"{name}\", {startIndex}) : {space}{(i++).ToString()}");
                Thread.Sleep(_InnoMath._GetRandomInt(100, 1000));
            }

            PrintLogLn($"ThreadFunc2(\"{name}\", {startIndex}) : {space}스레드 종료");

            return i;
        }

        private void btn_InnoNameThread_Start_Click(object sender, EventArgs e)
        {
            if (InnoNameThread._IsAnyRunning())
            {
                PrintLogLn("- 실행중인 스레드가 있습니다. 잠시 기다려 주세요...");
                return;
            }
            else
            {
                PrintLog("#", 100);
                PrintLog("_Thread.InnoThread 정적 사용 예제입니다.");
                PrintLog("#", 100);
            }

            InnoNameThread._SetOldClose(false);

            PrintLog("- ThreadFunc1 2개의 스레드를 시작합니다.");
            InnoNameThread._Start("1_1", (Action<string, int>)ThreadFunc1, "1_1", 0);
            InnoNameThread._Start("1_2", (Action<string, int>)ThreadFunc1, "1_2", 5);

            PrintLog("- ThreadFunc2 2개의 스레드를 시작합니다.");
            InnoNameThread._Start("2_1", (Func<string, int, int>)ThreadFunc2, "2_1", 0);
            InnoNameThread._Start("2_2", (Func<string, int, int>)ThreadFunc2, "2_2", 10);

            PrintLogLn();
        }

        private void btn_InnoNameThread_Stop_Click(object sender, EventArgs e)
        {
            if (!InnoNameThread._IsAnyRunning())
            {
                PrintLogLn("- 실행중인 스레드가 없습니다.");
                return;
            }
            else
            {
                PrintLog("- ThreadFunc1 2개의 스레드를 정지합니다.");
                InnoNameThread._Stop("1_1");
                InnoNameThread._Stop("1_2");

                PrintLog("- ThreadFunc2 2개의 스레드를 정지합니다.");
                InnoNameThread._Stop("2_1");
                InnoNameThread._Stop("2_2");

                //InnoNameThread._StopAll();
            }

            PrintLogLn();
        }


        InnoNameThread nameThread = new InnoNameThread();

        private void btnInnoNameThread_Start_Click(object sender, EventArgs e)
        {
            if (nameThread.IsAnyRunning())
            {
                PrintLogLn("- 실행중인 스레드가 있습니다. 잠시 기다려 주세요...");
                return;
            }
            else
            {
                PrintLog("#", 100);
                PrintLog("_Thread.InnoThread 사용 예제입니다.");
                PrintLog("#", 100);
            }

            nameThread.SetOldClose(false);

            PrintLog("- ThreadFunc1 2개의 스레드를 시작합니다.");
            nameThread.Start("1_1", (Action<string, int>)ThreadFunc1, "1_1", 0);
            nameThread.Start("1_2", (Action<string, int>)ThreadFunc1, "1_2", 5);

            PrintLog("- ThreadFunc2 2개의 스레드를 시작합니다.");
            nameThread.Start("2_1", (Func<string, int, int>)ThreadFunc2, "2_1", 0);
            nameThread.Start("2_2", (Func<string, int, int>)ThreadFunc2, "2_2", 10);

            PrintLogLn();
        }

        private void btnInnoNameThread_Stop_Click(object sender, EventArgs e)
        {
            if (!nameThread.IsAnyRunning())
            {
                PrintLogLn("- 실행중인 스레드가 없습니다.");
                return;
            }
            else
            {
                PrintLog("- ThreadFunc1 2개의 스레드를 정지합니다.");
                nameThread.Stop("1_1");
                nameThread.Stop("1_2");

                PrintLog("- ThreadFunc2 2개의 스레드를 정지합니다.");
                nameThread.Stop("2_1");
                nameThread.Stop("2_2");

                //nameThread._StopAll();
            }

            PrintLogLn();
        }
        #endregion
    }
}
