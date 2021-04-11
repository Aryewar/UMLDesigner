using System.Drawing;
using System.Drawing.Drawing2D;

namespace UMLDesigner
{
    class InheritArrows : Arrow
    {
        public InheritArrows(Pen pen, Point start, Point finish) : base(pen, start, finish)
        {
            ArrowPen.CustomEndCap = new AdjustableArrowCap(10, 10);
        }

        public override void DrawArrow(Graphics graphics, Point start, Point finish)
        {
            FinishPoint = finish;
            GraphicsPath hPath = new GraphicsPath();
            Point[] emptyTriangle = new Point[] { new Point(-6, 0),
                                                    new Point(6, 0),
                                                    new Point(0, 12),
                                                  };

            hPath.AddPolygon(emptyTriangle);
            ArrowPen.CustomEndCap = new CustomLineCap(null, hPath);

            graphics.DrawLine(ArrowPen, start, finish);
        }
    }
}
