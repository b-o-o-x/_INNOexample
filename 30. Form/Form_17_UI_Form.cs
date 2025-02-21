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
    public partial class Form_17_UI_Form : CustomFormVirtual
    {
        public Form_17_UI_Form()
        {
            InitializeComponent();
        }

        public Form_17_UI_Form(string formName)
        {
            InitializeComponent();
            this.Name = formName;
        }

        private void Form_Load(object sender, EventArgs e)
        {
            SetPrintLogControl(lbLog);
            _InnoFile._CreateDirectory(@".\_UI");
        }

        private void Form_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
