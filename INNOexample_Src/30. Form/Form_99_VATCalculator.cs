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

namespace INNOexample
{
    public partial class Form_99_VATCalculator : CustomFormVirtual
    {
        public Form_99_VATCalculator()
        {
            InitializeComponent();
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

        private void btnVAT_Calc1_Click(object sender, EventArgs e)
        {
            double totalAmount = txtTotalAmount.Text.ToDouble();
            double valueOfSupply = totalAmount / 1.1;
            double taxAmount = totalAmount - valueOfSupply;
            txtValueOfSupply.Text = Math.Round(valueOfSupply).ToCommaString();
            txtTaxAmount.Text = Math.Round(taxAmount).ToCommaString();

            PrintMemo($"합계금액 {txtTotalAmount.Text} 원의 공급가액은 {txtValueOfSupply.Text} 원이며 세액은 {txtTaxAmount.Text} 원입니다.");
        }

        private void btnVAT_Calc2_Click(object sender, EventArgs e)
        {
            double valueOfSupply = txtValueOfSupply2.Text.ToDouble();
            double taxAmount = valueOfSupply * 0.1;
            double totalAmount = valueOfSupply + taxAmount;
            txtTaxAmount2.Text = Math.Round(taxAmount).ToCommaString();
            txtTotalAmount2.Text = Math.Round(totalAmount).ToCommaString();

            PrintMemo($"공급가액 {txtValueOfSupply2.Text} 원의 세액은 {txtTaxAmount2.Text} 원이며 합계금액은 {txtTotalAmount2.Text} 원입니다.");
        }

        private void btnBusinessIncome_Calc1_Click(object sender, EventArgs e)
        {
            double businessIncome = txtBusinessIncome.Text.ToDouble();
            double incomeTax = businessIncome * 0.03;
            double residentTax = businessIncome * 0.003;
            double payment = businessIncome - incomeTax - residentTax;
            txtIncomeTax.Text = Math.Round(incomeTax).ToCommaString();
            txtResidentTax.Text = Math.Round(residentTax).ToCommaString();
            txtPayment.Text = Math.Round(payment).ToCommaString();

            PrintMemo($"사업소득 {txtBusinessIncome.Text} 원의 세액은 {Math.Round(incomeTax + residentTax).ToCommaString()} 원이며 지급액은 {txtPayment.Text} 원입니다.");
        }

        private void btnBusinessIncome_Calc2_Click(object sender, EventArgs e)
        {
            double payment = txtPayment2.Text.ToDouble();
            double businessIncome = payment / 0.967;
            double incomeTax = businessIncome * 0.03;
            double residentTax = businessIncome * 0.003;
            txtBusinessIncome2.Text = Math.Round(businessIncome).ToCommaString();
            txtIncomeTax2.Text = Math.Round(incomeTax).ToCommaString();
            txtResidentTax2.Text = Math.Round(residentTax).ToCommaString();

            PrintMemo($"지급액 {txtPayment2.Text} 원의 세액은 {Math.Round(incomeTax + residentTax).ToCommaString()} 원이며 사업소득은 {txtBusinessIncome2.Text} 원입니다.");
        }
    }
}
