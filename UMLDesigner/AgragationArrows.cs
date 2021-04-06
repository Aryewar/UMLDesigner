using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMLDesigner
{
    class AgragationArrows: Arrow
    {
        public AgragationArrows(Pen pen, Point start, Point finish) : base(pen, start, finish)
        {

        }

        public override void DrawArrow(Graphics graphics, Point start, Point finish)
        {
            FinishPoint = finish;
            GraphicsPath hPath = new GraphicsPath();
            Point[] filledRhombus = new Point[] { new Point(0, -6),
                                                    new Point(3, 0),
                                                    new Point(0, 6),
                                                    new Point(-3, 0)
                                                  };

            hPath.AddPolygon(filledRhombus);
            ArrowPen.CustomEndCap = new CustomLineCap(hPath, null);

            graphics.DrawLine(ArrowPen, start, finish);
        }
    }
}
