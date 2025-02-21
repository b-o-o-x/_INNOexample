using _Custom;
using _INNO._File;
using _INNO._Shape;
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
    public partial class Form_12_Shape : CustomFormVirtual
    {
        public Form_12_Shape()
        {
            InitializeComponent();
        }

        private void Form_Load(object sender, EventArgs e)
        {
            SetPrintLogControl(lbLog);
            _InnoFile._CreateDirectory(@".\_Shape");
        }

        private void btnDrawBegin_Click(object sender, EventArgs e)
        {
            //shapeView._mouseControllable = false;
            //shapeView.drawMode = true;
        }

        private void btnDrawEnd_Click(object sender, EventArgs e)
        {
            //shapeView._mouseControllable = true;
            //shapeView.drawMode = false;
        }

        private void btnCreateMap_Click(object sender, EventArgs e)
        {
            CustomShapeMap.MapInfo info = new CustomShapeMap.MapInfo();
            info.type = InnoShapeUIViewer.ShapeObjectType.CIRCLE;
            info.distance = 20;
            info.diameter = 18;
            info.xCount = 10;
            info.yCount = 10;
            map.CreateMap(info);
        }

        private void btnMapTest_Click(object sender, EventArgs e)
        {

        }
    }
}
