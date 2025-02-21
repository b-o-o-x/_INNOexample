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
    public partial class Form_Blank : CustomFormVirtual
    {
        public Form_Blank()
        {
            InitializeComponent();
        }

        public Form_Blank(string formName)
        {
            InitializeComponent();
            this.Name = formName;
        }

        private void Form_Load(object sender, EventArgs e)
        {
            SetPrintLogControl(lbLog);
        }

        private void Form_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
