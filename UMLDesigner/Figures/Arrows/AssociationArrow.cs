using System.Drawing;
using System.Drawing.Drawing2D;

namespace UMLDesigner.Figures.Arrows
{
    public class AssociationArrow : AbstractArrow
    {
        public AssociationArrow()
        {
            PenWidth = (int)_painter.PainterPen.Width;
            PenColor = _painter.PainterPen.Color;
            FigurePen = new Pen(PenColor, PenWidth);

            FigurePen.CustomEndCap = new AdjustableArrowCap(10, 10, false);

            figureType = SinglePainter.Painter.FigureType.AssociationArrow;
        }
        
    }
}
