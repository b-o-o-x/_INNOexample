using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using _INNO;
using _INNO._System;

namespace INNOexample
{
    internal static class Program
    {
        /// <summary>
        /// 해당 애플리케이션의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Inno
            //Inno.Inst.SetLogSave(saveCaller: true);
            Inno.Inst.SetExceptionController(Inno.ExceptionControl.EC_NOTIFY); // EC_THROW | EC_NOTIFY
            Inno.Inst.Init(); // => FormMain.Load()시에도 가능
            //Inno.Inst.CheckLicense(); // 라이선스 체크
            Application.Run(new FormMain());
            Inno.Inst.Deinit(); // => FormMain.FormClosing()시에도 가능
        }
    }
}
