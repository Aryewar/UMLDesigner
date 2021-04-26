using System.Drawing;
using System.Drawing.Drawing2D;

namespace UMLDesigner.Figures.Arrows
{
    public class AlternateCompositionArrow : AbstractArrow
    {
        public AlternateCompositionArrow()
        {
            PenWidth = (int)_painter.PainterPen.Width;
            PenColor = _painter.PainterPen.Color;
            FigurePen = new Pen(PenColor, PenWidth);

            GraphicsPath hPath = new GraphicsPath();
            Point[] filledRhombus = new Point[] {
                new Point(0, 0),
                new Point(-3, -6),
                new Point(0, -12),
                new Point(3, -6)
            };

            hPath.AddPolygon(filledRhombus);
            FigurePen.CustomStartCap = new CustomLineCap(hPath, null);
            FigurePen.CustomEndCap = new AdjustableArrowCap(9, 9, false);

            figureType = SinglePainter.Painter.FigureType.AlternateCompositionArrow;
        }
        
    }
}
