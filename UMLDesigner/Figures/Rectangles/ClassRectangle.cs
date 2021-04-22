using System.Drawing;

namespace UMLDesigner.Figures.Rectangles
{
    public class ClassRectangle: AbstractRectangle
    {
        public ClassRectangle()
        {
            PenWidth = _painter.PainterPen.Width;
            FigurePen = new Pen(_painter.PainterPen.Color, PenWidth*_painter.Scale);
            FigureBackColor = _painter.PainterBrush;
            Type = "ClassRectangle";
        }
    }
}
