using _INNO;
using _INNO._File;
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
    public partial class Form_99_BusinessCostCalculator : CustomFormVirtual
    {
        public Form_99_BusinessCostCalculator()
        {
            InitializeComponent();
        }

        private void Form_04_Salary_Load(object sender, EventArgs e)
        {
            
        }

        public int PrintMemo(string memo)
        {
            int ret = listBox1.Items.Add(memo);
            // Set to End
            listBox1.SelectedIndex = listBox1.Items.Count - 1;
            listBox1.SelectedIndex = -1;
            return ret;
        }

        public int PrintMemo(string title, string memo)
        {
            return PrintMemo(title + " = " + memo);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void txtTotalAmount_MouseDown(object sender, MouseEventArgs e)
        {
            //txtTotalAmount.Text = "";
            //txtValueOfSupply.Text = "";
            //txtTaxAmount.Text = "";
            //txtTotalAmount.Select(txtTotalAmount.Text.Length, 0);
        }

        private void txt__TextChanged(object sender, EventArgs e)
        {
            TextBox con = sender as TextBox;
            con.Text = con.Text.ToCommaString();
            con.Select(con.Text.Length, 0);
        }

        private void ContractCost(string projectName, string iniFile)
        {
            double total = 0.0;

            InnoIni ini = new InnoIni();
            ini.SetFullPath($@".\_Data\{iniFile}");
            string[] secs = ini.ReadSectionList();
            for (int i = 0; i < secs.Length; i++)
            {
                string sec = secs[i];
                double totalIncome = 0.0;

                if (sec.Contains("#계약#"))
                {
                    string[] keys = ini.ReadKeyList(sec);
                    for (int j = 0; j < keys.Length; j++)
                    {
                        double monthIncome = ini.ReadDouble(sec, keys[j]);
                        totalIncome += monthIncome;
                    }
                    total += totalIncome;
                }
            }

            txtBusinessIncome.Text = total.ToCommaString();
            PrintMemo($"{projectName} 프로젝트 계약금액은 {total.ToCommaString()} 원입니다.");
        }

        private void BusinessCost(string projectName, string iniFile)
        {
            ContractCost(projectName, iniFile);

            double total = 0.0;

            InnoIni ini = new InnoIni();
            ini.SetFullPath($@".\_Data\{iniFile}");
            string[] secs = ini.ReadSectionList();
            for (int i = 0; i < secs.Length; i++)
            {
                string sec = secs[i];
                double totalIncome = 0.0;

                if (sec.Contains("#"))
                    continue;

                string[] keys = ini.ReadKeyList(sec);
                for (int j = 0; j < keys.Length; j++)
                {
                    double monthIncome = ini.ReadDouble(sec, keys[j]);
                    PrintMemo($"{sec} {keys[j]} 지급액 {monthIncome.ToCommaString()} 원");
                    totalIncome += monthIncome;
                }
                PrintMemo($"{sec} 님에게 총 지급된 사업소득금액은 {totalIncome.ToCommaString()} 원입니다.");
                total += totalIncome;
            }

            ContractCost(projectName, iniFile);
            txtBusinessExpenses.Text = total.ToCommaString();
            PrintMemo($"{projectName} 프로젝트를 위해 총 지출된 사업비용은 {txtBusinessExpenses.Text} 원입니다.");

            txtBusinessProfit.Text = (txtBusinessIncome.Text.ToDouble() - txtBusinessExpenses.Text.ToDouble()).ToCommaString();
        }

        private void btnCal_HBT_CRP_Click(object sender, EventArgs e)
        {
            BusinessCost("HBT CRP", "Cost_HBT_CRP.ini");
        }

        private void btnCal_HBT_VisionSetup_Click(object sender, EventArgs e)
        {
            BusinessCost("HBT VisionSetup", "Cost_HBT_VisionSetup.ini");
        }

        private void btnCal_HBT_JellyRoll_Click(object sender, EventArgs e)
        {

        }
    }
}
