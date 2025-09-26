//================================================================================
//
// _INNO._Shape.CustomShapeMap
//
//================================================================================
//                                   Copyright @ Innosoft 2019. http://innosoft.kr
//                      Copyright @ (주)북스 BOOX, Inc. 2023. http://www.boox.co.kr
//                                   Andy Yang - booxboox@naver.com, 010-3292-3892
//================================================================================
// [생성]
// 1. 작성자 : Andy Yang
// 2. 작성일 : 2025-02-13
//--------------------------------------------------------------------------------
// [설명]
// 1. CustomShapeMap 클래스
//--------------------------------------------------------------------------------
// [이력]
// <날짜>   <작성자>   <설명>
// 25-02-13 Andy Yang Initial.
//================================================================================
//
using _INNO._Math;
using _INNO._Shape;
using _INNO._Time;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace _Custom
{
    /// <summary>
    /// InnoShapeMap 클래스
    /// </summary>
    public class CustomShapeMap : InnoShapeUIViewer
    {
        InnoTimerCallback timer = null;

        public class MapInfo
        {
            //int sizeX = // 필요한가.. 현재 자동 계산이라..
            public ShapeObjectType type = ShapeObjectType.CIRCLE;
            public int distance = 10;
            public int diameter = 3;
            public int xCount = 10;
            public int yCount = 10;
        }
        private MapInfo mapInfo = null;

        public CustomShapeMap()
        {
            //timer = new InnoTimerCallback(this, timer_Tick);
            //timer.Start(500);

            this.pb.MouseClick += new MouseEventHandler(OnMouseClick);
        }

        private void OnMouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ShapeObject so = FindShapeObject(e.Location);// GetShapeObject(i);
                if (so != null)
                {
                    if (IsOn(so.name)) Off(so.name);
                    else On(so.name);
                }
            }
        }

        void timer_Tick()
        {
            if (mapInfo != null)
            {
                for (int y = 0; y < mapInfo.yCount; y++)
                {
                    for (int x = 0; x < mapInfo.xCount; x++)
                    {
                        int num = _InnoMath._GetRandomInt(0, 1);
                        if (num == 0) Off(x, y);
                        else On(x, y);
                    }
                }
            }
        }

        /// <summary>
        /// 맵을 생성합니다.
        /// </summary>
        /// <param name="Xmms"></param>
        /// <param name="Ymms"></param>
        public void CreateMap(MapInfo info)
        {
            this.Clear();

            this.mapInfo = info;

            for (int y = 0; y < info.yCount; y++)
            {
                for (int x = 0; x < info.xCount; x++)
                {
                    double diameter = info.distance;
                    double radius = info.diameter / 2;// info.distance / 2;

                    PointD ptCenter = new PointD((x + 1) * (info.distance),
                                                 (y + 1) * (info.distance));
                    if (info.type == ShapeObjectType.CIRCLE)
                    {
                        string name = $"MAP_X{x}Y{y}";
                        AddShapeCircleFill(name, ptCenter, radius, rgbPen: Color.White, rgbBrush: Color.Gray);
                    }
                }
            }

            //CalculateUICoordinates();

            Invalidate();
        }

        public void On(int x, int y)
        {
            string name = $"MAP_X{x}Y{y}";
            On(name);
        }

        public void On(string name)
        {
            ShapeObject so = FindShapeObject(name);
            if (so != null)
            {
                so.rgbPen = Color.Lime;
                so.rgbBrush = Color.LimeGreen;
                so.text = "ON";
                EditShapeObject(so);
                Invalidate();
            }
        }

        public bool IsOn(string name)
        {
            ShapeObject so = FindShapeObject(name);
            return so?.text == "ON";
        }

        public void Off(int x, int y)
        {
            string name = $"MAP_X{x}Y{y}";
            Off(name);
        }

        public void Off(string name)
        {
            ShapeObject so = FindShapeObject(name);
            if (so != null)
            {
                so.rgbPen = Color.White;
                so.rgbBrush = Color.Gray;
                so.text = "";
                EditShapeObject(so);
                Invalidate();
            }
        }
    }
}
