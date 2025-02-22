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
    public partial class Form_11_Security : CustomFormVirtual
    {
        public Form_11_Security()
        {
            InitializeComponent();
        }

        public Form_11_Security(string formName)
        {
            InitializeComponent();
            this.Name = formName;
        }

        private void Form_Load(object sender, EventArgs e)
        {
            SetPrintLogControl(lbLog);
            _InnoFile._CreateDirectory(@".\_Security");
        }

        private void Form_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
