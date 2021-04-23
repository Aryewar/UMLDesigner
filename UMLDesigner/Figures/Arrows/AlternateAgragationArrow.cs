using System.Drawing;
using System.Drawing.Drawing2D;
using UMLDesigner.Figures.SinglePainter;

namespace UMLDesigner.Figures.Arrows
{
    public class AlternateAgragationArrow : AbstractArrow
    {
        public AlternateAgragationArrow()
        {
            PenWidth = (int)_painter.PainterPen.Width;
            PenColor = _painter.PainterPen.Color;
            FigurePen = new Pen(PenColor, PenWidth);

            GraphicsPath hPath = new GraphicsPath();
            Point[] filledRhombus = new Point[] { new Point(0, -12),
                                                    new Point(3, -6),
                                                    new Point(0, 1),
                                                    new Point(-3, -6)
                                                  };

            hPath.AddPolygon(filledRhombus);
            FigurePen.CustomStartCap = new CustomLineCap(hPath, null);
            FigurePen.CustomEndCap = new AdjustableArrowCap(9, 9, false);
            figureType = Painter.FigureType.AlternateAgragationArrow;
        }
    }
}
