using System.Drawing;
using System.Drawing.Drawing2D;
using UMLDesigner.Figures.SinglePainter;

namespace UMLDesigner.Figures.Arrows
{
    public class InharitanceArrow : AbstractArrow
    {
        public InharitanceArrow()
        {
            FigurePen = new Pen(Painter.PainterPen.Color, Painter.PainterPen.Width);
            FigurePen.CustomEndCap = new AdjustableArrowCap(10, 10);
        }
    }
}
