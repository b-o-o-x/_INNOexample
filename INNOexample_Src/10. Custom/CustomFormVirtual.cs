//================================================================================
//
// _INNO._Custom.CustomFormVirtual
//
//================================================================================
//                                   Copyright @ Innosoft 2019. http://innosoft.kr
//                      Copyright @ (주)북스 BOOX, Inc. 2023. http://www.boox.co.kr
//                                   Andy Yang - booxboox@naver.com, 010-3292-3892
//================================================================================
// [생성]
// 1. 작성자 : Andy Yang
// 2. 작성일 : 2025-01-01
//--------------------------------------------------------------------------------
// [설명]
// 1. 고객맞춤 폼 확장 클래스
//--------------------------------------------------------------------------------
// [이력]
// <날짜>    <작성자>    <설명>
// 25-01-01  Andy Yang	Initial.
// 25-01-27  Andy Yang  좀더 정확한 코드구동시간 확인을 위해 로그파일 쓰지 않는 LogManager 사용으로 변경.
// 25-01-28  Andy Yang  1) LogType 추가
// 25-02-02  Andy Yang  LogControl Invoke()
// 25-02-06  Andy Yang  LogControl 더블클릭시 기능 추가
//================================================================================
//
using System;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using _INNO;
using _INNO._Data;
using _INNO._File;
using _INNO._Lang;
using _INNO._Machine;
using _INNO._System;
using INNOexample;

namespace INNOexample
{
    public partial class CustomFormVirtual : _INNO._UI.InnoFormVirtual
    {
        // Alias
        protected _Global _G = null;
        //protected _DataManager _Data = null;

        protected InnoLogManager LogManager = new InnoLogManager();

        // Map
        protected static class _Map
        {
            //public static InnoDataCsv AlarmMap = _Global.Instance.dataAlarmMap;
        }

        public CustomFormVirtual()
        {
            if (Inno._IsRuntime())
            {
                // Alias
                _G = _Global.Inst;
                //_Data = _DataManager.Inst;
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            LogManager.SetFileSave(false); // 파일 쓰지 않음
            LogManager.Init(); // 쓰기 QueueThread 사용하며 구동

            base.OnLoad(e);

            // 다국어 자동화
            if (Inno._IsRuntime())
            {
                _G._Lang.Apply(this);
                InnoLangCsv.LangChanged += FormLangChanged;
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            // 다국어 자동화
            if (Inno._IsRuntime())
            {
                InnoLangCsv.LangChanged -= FormLangChanged;
            }

            LogManager.Deinit();
        }

        protected void FormLangChanged(object sender, string msg)
        {
            // 다국어 자동화
            if (Inno._IsRuntime())
            {
                _G._Lang.Apply(this);
            }
        }

        protected override void OnReload(EventArgs e)
        {
            base.OnReload(e);
        }

        protected override void OnHide(EventArgs e)
        {
        }

        protected override void OnMaximized(EventArgs e)
        {
        }

        protected override void OnMinimized(EventArgs e)
        {
        }

        protected override void OnNormalized(EventArgs e)
        {
        }

        protected override void TimerVisibleRefresh_Tick(object sender, EventArgs e)
        {
        }

        protected override void TimerRefresh_Tick(object sender, EventArgs e)
        {
        }

        protected override void TimerVisibleElapsed_Tick(object sender, EventArgs e)
        {
        }

        protected override void TimerHideElapsed_Tick(object sender, EventArgs e)
        {
        }


        #region // INNOexample용 폼 전체에 적용되는 함수 추가

        ListBox logControl = null;

        public void SetPrintLogControl(ListBox lb)
        {
            logControl = lb;

            if (logControl != null)
            {
                Button b = new Button();
                b.Name = "btnClear";
                b.Text = "Clear";
                b.Parent = logControl;
                b.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
                b.Location = new Point(logControl.Width - b.Width - 3, logControl.Height - b.Height - 3);
                b.Click += btnClear_Click;
                logControl.Controls.Add(b);

                logControl.DoubleClick += LogControl_DoubleClick;

                if (LogManager != null)
                    LogManager.AttachLogControl(logControl);
            }
        }

        private void LogControl_DoubleClick(object sender, EventArgs e)
        {
            if (logControl != null)
            {
                string line = logControl.SelectedItem.ToString();
                string[] parts = line.Split(' ');
                for (int i = 0; i < parts.Length; i++)
                {
                    string part = parts[i];
                    if (part.Contains("\\")) // "\" 포함이면 폴더 또는 파일로 고려하여 해당 파트 실행
                    {
                        _InnoSystem._RunProcess(part);
                    }
                    else
                    {
                        if (!LogManager.GetFullPath().IsNullOrWhiteSpace()) // 로그 파일 설정되어 있다면 로그 파일 열기
                        {
                            _InnoSystem._RunProcess(LogManager.GetFullPath());
                        }
                    }
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearPrintLog();
        }

        public void PrintLogDirectButSlow(string text = "")
        {
            if (logControl != null)
            {
                logControl.BeginUpdate();

                string dateTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff");

                text = $"{{{dateTime}}} {text}";

                logControl.Items.Add(text);
                // Set to End
                logControl.SelectedIndex = logControl.Items.Count - 1;
                logControl.SelectedIndex = -1;

                // Force call Resize
                typeof(Control).GetMethod("OnResize", BindingFlags.Instance | BindingFlags.NonPublic)
                    .Invoke(logControl, new object[] { EventArgs.Empty });

                logControl.EndUpdate();
            }
        }

        public void PrintLog(string text = "", string logType = "")
        {
            LogManager.Log(text, logType);

            // Force call Resize
            logControl?.Invoke((MethodInvoker)delegate ()
            {
                typeof(Control).GetMethod("OnResize", BindingFlags.Instance | BindingFlags.NonPublic)
                    .Invoke(logControl, new object[] { EventArgs.Empty });
            });
        }

        public void PrintLog(string text, int repeat)
        {
            string newTxt = "";
            for (int i = 0; i < repeat; i++)
            {
                newTxt += text;
            }
            PrintLog(newTxt);
        }

        public void PrintLogLn(string text = "", string logType = "")
        {
            if (!text.IsNullOrEmpty()) PrintLog($"{text}", logType);
            PrintLog("");
        }

        public void ClearPrintLog()
        {
            logControl?.Items.Clear();
        }
        #endregion
    }
}
