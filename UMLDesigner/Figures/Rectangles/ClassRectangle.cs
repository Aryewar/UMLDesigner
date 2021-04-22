using System.Drawing;

namespace UMLDesigner.Figures.Rectangles
{
    public class ClassRectangle: AbstractRectangle
    {
        public ClassRectangle()
        {
            FigurePen = new Pen(_painter.PainterPen.Color, _painter.PainterPen.Width*(int)(_painter.Scale/100));
            FigureBackColor = _painter.PainterBrush;
        }
    }
}
