using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMLDesigner
{
    class InheritArrows : Arrow
    {
        public InheritArrows(Pen pen, Point start, Point finish) : base(pen, start, finish)
        {
            Pen.CustomEndCap = new AdjustableArrowCap(10, 10);
        }

        public override void DrawArrow(Graphics graphics, Point start, Point finish)
        {
            FinishPoint = finish;
            graphics.DrawLine(Pen, start, finish);

            //Point apex1 = new Point();
            //Point apex2 = new Point();
            //PointF[] arrowCup = new PointF[] { apex1, apex2, finish };
        }
    }
}
