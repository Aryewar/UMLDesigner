using System.Drawing;
using System.Drawing.Drawing2D;
using UMLDesigner.Figures.SinglePainter;

namespace UMLDesigner.Figures.Arrows
{
    public class AssociationArrow : AbstractArrow
    {
        public AssociationArrow()
        {
            FigurePen = new Pen(_painter.PainterPen.Color, _painter.PainterPen.Width);
            FigurePen.CustomEndCap = new AdjustableArrowCap(10, 10, false);
            FigureType = Painter.FigureType.AssociationArrow.ToString();
        }
        
    }
}
