using System.Drawing;

namespace UMLDesigner.Figures.Rectangles
{
    public class ClassRectangle: AbstractRectangle
    {
        public ClassRectangle()
        {
            PenWidth = (int)_painter.PainterPen.Width;
            PenColor = _painter.PainterPen.Color;
            FigurePen = new Pen(PenColor, PenWidth);
            FigureBackColor = _painter.PainterBrush.Color;
            FigureBrush = new SolidBrush(FigureBackColor);

            figureType = SinglePainter.Painter.FigureType.ClassRectangle;
        }
    }
}
