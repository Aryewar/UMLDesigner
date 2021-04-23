using System.Drawing;

namespace UMLDesigner.Figures.Rectangles
{
    public class ClassRectangle: AbstractRectangle
    {
        public ClassRectangle()
        {
            FigurePen = new Pen(_painter.PainterPen.Color, _painter.PainterPen.Width);
            FigureBackColor = _painter.PainterBrush;

            figureType = SinglePainter.Painter.FigureType.ClassRectangle;
        }
    }
}
