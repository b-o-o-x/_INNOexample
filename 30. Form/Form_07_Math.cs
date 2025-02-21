using _INNO;
using _INNO._File;
using _INNO._Math;
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
    public partial class Form_07_Math : CustomFormVirtual
    {
        public Form_07_Math()
        {
            InitializeComponent();
        }

        public Form_07_Math(string formName)
        {
            InitializeComponent();
            this.Name = formName;
        }

        private void Form_Load(object sender, EventArgs e)
        {
            SetPrintLogControl(lbLog);
            _InnoFile._CreateDirectory(@".\_Math");
        }

        private void Form_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void btn_InnoMath_Click(object sender, EventArgs e)
        {
            PrintLog("#", 100);
            PrintLog("_Math._InnoMath 사용 예제입니다.");
            PrintLog("#", 100);

            PrintLog($"_InnoMath._Temperature._CelsiusToFahrenheit(0); \t\t=> {_InnoMath._Temperature._CelsiusToFahrenheit(0)}{_InnoMath._Temperature._FahrenheitSymbol}");
            PrintLog($"_InnoMath._Temperature._FahrenheitToCelsius(-17.8); \t\t=> {_InnoMath._Temperature._FahrenheitToCelsius(-17.8)}{_InnoMath._Temperature._CelsiusSymbol}");
            PrintLog($"_InnoMath._GetRandomInt(10, 20); \t\t\t\t=> {_InnoMath._GetRandomInt(10, 20)}");
            PrintLog($"_InnoMath._GetRandomIntArray(5, 10, 20); \t\t\t=> {_InnoMath._GetRandomIntArray(5, 10, 20).ToDisplayString()}");
            PrintLog($"_InnoMath._GetRandomIntArrayWithoutDuplicate(5, 10, 20); \t=> {_InnoMath._GetRandomIntArrayWithoutDuplicate(5, 10, 15).ToDisplayString()}");
            PrintLog($"_InnoMath._GetRandomDouble(10, 20); \t\t\t=> {_InnoMath._GetRandomDouble(10, 20)}");
            PrintLog($"_InnoMath._GetRandomDoubleArray(5, 10, 20); \t\t\t=> {_InnoMath._GetRandomDoubleArray(5, 10, 20).ToDisplayString()}");
            PrintLog($"_InnoMath._GetRandomDoubleArrayWithoutDuplicate(5, 10, 20); \t=> {_InnoMath._GetRandomDoubleArrayWithoutDuplicate(5, 10, 15).ToDisplayString()}");
        }
    }
}
