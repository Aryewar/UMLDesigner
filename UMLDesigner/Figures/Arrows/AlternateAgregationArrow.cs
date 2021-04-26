using System.Drawing;
using System.Drawing.Drawing2D;
using UMLDesigner.Figures.SinglePainter;

namespace UMLDesigner.Figures.Arrows
{
    public class AlternateAgregationArrow : AbstractArrow
    {
        public AlternateAgregationArrow()
        {
            PenWidth = (int)_painter.PainterPen.Width;
            PenColor = _painter.PainterPen.Color;
            FigurePen = new Pen(PenColor, PenWidth);

            GraphicsPath hPath = new GraphicsPath();
            Point[] filledRhombus = new Point[] { new Point(0, -16),
                                                    new Point(4, -8),
                                                    new Point(0, 0),
                                                    new Point(-4, -8)
                                                  };

            hPath.AddPolygon(filledRhombus);
            FigurePen.CustomStartCap = new CustomLineCap(null, hPath);
            FigurePen.CustomEndCap = new AdjustableArrowCap(9, 9, false);
            figureType = Painter.FigureType.AlternateAgragationArrow;
        }
    }
}
