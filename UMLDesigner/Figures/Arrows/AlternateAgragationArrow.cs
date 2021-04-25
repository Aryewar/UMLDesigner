using System.Drawing;
using System.Drawing.Drawing2D;
using UMLDesigner.Figures.SinglePainter;

namespace UMLDesigner.Figures.Arrows
{
    public class AlternateAgragationArrow : AbstractArrow
    {
        public AlternateAgragationArrow()
        {
            FigurePen = new Pen(_painter.PainterPen.Color, _painter.PainterPen.Width);

            GraphicsPath hPath = new GraphicsPath();
            Point[] filledRhombus = new Point[] { new Point(0, -8),
                                                    new Point(2, -4),
                                                    new Point(0, 1),
                                                    new Point(-2, -4)
                                                  };

            hPath.AddPolygon(filledRhombus);
            FigurePen.CustomStartCap = new CustomLineCap(hPath, null);
            FigurePen.CustomEndCap = new AdjustableArrowCap(9, 9, false);
            Type = "AlternateAgragationArrow";
        }
    }
}
