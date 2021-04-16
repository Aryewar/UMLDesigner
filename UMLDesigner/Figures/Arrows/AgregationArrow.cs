using System.Drawing;
using System.Drawing.Drawing2D;
using UMLDesigner.Figures.SinglePainter;

namespace UMLDesigner.Figures.Arrows
{
    public class AgregationArrow : AbstractArrow
    {
        public AgregationArrow()
        {
            FigurePen = new Pen(_painter.PainterPen.Color, _painter.PainterPen.Width);

            GraphicsPath hPath = new GraphicsPath();
            Point[] filledRhombus = new Point[] { new Point(0, -12),
                                                    new Point(3, -6),
                                                    new Point(0, 1),
                                                    new Point(-3, -6)
                                                  };

            hPath.AddPolygon(filledRhombus);
            FigurePen.CustomEndCap = new CustomLineCap(hPath, null);
        }
    }
}
