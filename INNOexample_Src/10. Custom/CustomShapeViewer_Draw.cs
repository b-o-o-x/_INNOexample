//================================================================================
//
// _INNO._Custom.CustomShapeViewer_Draw
//
//================================================================================
//                                   Copyright @ Innosoft 2019. http://innosoft.kr
//                      Copyright @ (주)북스 BOOX, Inc. 2023. http://www.boox.co.kr
//                                   Andy Yang - booxboox@naver.com, 010-3292-3892
//================================================================================
// [생성]
// 1. 작성자 : Andy Yang
// 2. 작성일 : 2024-10-27
//--------------------------------------------------------------------------------
// [설명]
// 1. 고객맞춤 InnoShape 도형 그리기 클래스
//--------------------------------------------------------------------------------
// [이력]
// <날짜>     <작성자>   <설명>
// 2019-08-01 Andy Yang Initial.
//================================================================================
//
using _INNO._Shape;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _INNO._Custom
{
    /// <summary>
    /// InnoShapeViewer_Draw 클래스
    /// </summary>
    public class CustomShapeViewer_Draw : InnoShapeViewer
    {
        int TotalCount = 0;

        public bool drawMode = false;

        /// <summary>
        /// 생성자
        /// </summary>
        public CustomShapeViewer_Draw()
        {
            pb.MouseDown += new MouseEventHandler(OnMouseDown);
        }

        private void OnMouseDown(object sender, MouseEventArgs e)
        {
            if (drawMode)
            {
                PointD pt1 = new PointD(e.X - 1, e.Y - 1);
                PointD pt2 = new PointD(5, 5); // Radius

                //AddShapeEllipse(TotalCount.ToString(), pt1, pt2, null, Color.White, Color.White);
                AddShapeCircle((++TotalCount).ToString(), pt1, pt2, null, Color.White);

                //CalculateUICoordinates();

                Invalidate();
            }
        }

        /// <summary>
        /// 데이터를 추가합니다.
        /// </summary>
        /// <param name="Xmms"></param>
        /// <param name="Ymms"></param>
        public void AddData(double[] Xmms, double[] Ymms)
        {
            // UI World에 맞도록 Data 계산..
            //CalculateWorldCoordinates(Xmms, Ymms);

            // 계산된 Shape Object 데이터 추가..
            for (int i = 0; i < Xmms.Length; i++)
            {
                AddShapeEllipse(i.ToString(), new PointD(Xmms[i] - 1, Ymms[i] - 1), new PointD(Xmms[i] + 1, Ymms[i] + 1), null, Color.White, Color.White);
            }

            //@@ 이렇게 임의의 Shape가 추가 되기 때문에.. ShapeObject의 갯수로 무언가 동작하는 코드는 위험할 수 있다.
            //   대신 특정 name 등의 Shape 갯수를 찾는 방법등은 고려해 볼 수 있겠다.
            AddShapeCircle("CURSOR", new PointD(Xmms[0], Ymms[0]), new PointD(3, 3), null, Color.Gold);

            CalculateUICoordinates();

            Invalidate();
        }

        /// <summary>
        /// Off
        /// </summary>
        /// <param name="i"></param>
        public void Off(int i)
        {
            ShapeObject eo = FindShapeObject(i);
            AddShapeEllipse(i.ToString(), eo.pt[0], eo.pt[1], null, Color.White, Color.White);
        }

        /// <summary>
        /// 모두 Off
        /// </summary>
        public void OffAll()
        {
            if (_uiPointArray == null) return;

            for (int i = 0; i < _uiPointArray.Count; i++)
            {
                Off(i);
            }
        }

        /// <summary>
        /// On
        /// </summary>
        /// <param name="i"></param>
        public void On(int i)
        {
            ShapeObject eo = FindShapeObject(i);
            AddShapeEllipse(i.ToString(), eo.pt[0], eo.pt[1], null, Color.White, Color.Lime);
        }

        /// <summary>
        /// 커서를 설정합니다.
        /// </summary>
        /// <param name="i"></param>
        public void SetCursor(int i)
        {
            ShapeObject eo = FindShapeObject(i);
            if (eo == null) return;
            AddShapeCircle("CURSOR", eo.pt[0], new PointD(5, 5), null, Color.Gold);
            Invalidate();
        }
    }
}
