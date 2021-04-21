using System;
using System.Drawing;
using UMLDesigner.Figures.SinglePainter;

namespace UMLDesigner.Figures.Rectangles
{
    public class ClassRectangle: AbstractRectangle
    {
        public ClassRectangle()
        {
            FigurePen = new Pen(_painter.PainterPen.Color, _painter.PainterPen.Width);
            FigureBackColor = _painter.PainterBrush;
            FigureType = Painter.FigureType.ClassRectangle.ToString();
        }
    }
}
