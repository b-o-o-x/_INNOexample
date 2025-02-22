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
    public partial class Form_Information : CustomFormVirtual
    {
        public Form_Information()
        {
            InitializeComponent();
        }

        private void PICClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void linkBoox_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _INNO._System._InnoSystem._ExecuteProcess("http://www.boox.co.kr");
        }

        private void linkInnosoft_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _INNO._System._InnoSystem._ExecuteProcess("http://www.innosoft.kr");
        }
    }
}
