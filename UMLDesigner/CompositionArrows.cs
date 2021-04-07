using System.Drawing;
using System.Drawing.Drawing2D;

namespace UMLDesigner
{
    class CompositionArrows: Arrow
    {
        public CompositionArrows(Pen pen, Point start, Point finish) : base(pen, start, finish)
        {

        }

        public override void DrawArrow(Graphics graphics, Point start, Point finish)
        {
            FinishPoint = finish;
            GraphicsPath hPath = new GraphicsPath();
            Point[] filledRhombus = new Point[] { new Point(0, 0),
                                                    new Point(3, 6),
                                                    new Point(0, 12),
                                                    new Point(-3, 6)
                                                  };

            hPath.AddPolygon(filledRhombus);
            ArrowPen.CustomEndCap = new CustomLineCap(null, hPath);

            graphics.DrawLine(ArrowPen, start, finish);
        }
    }
}
