using System;
using System.Drawing;

using UMLDesigner.Figures.SinglePainter;

namespace UMLDesigner.Figures.Arrows
{
    public class AbstractArrow : IFigure
    {
        public Point StartPoint { get; set; }
        public Point FinishPoint { get; set; }
        public Pen FigurePen { get; set;}

        public void Draw()
        {
            FigurePen.Color = Painter.PainterPen.Color;
            FigurePen.Width = Painter.PainterPen.Width;
            Painter.PainterGraphics.DrawLine(FigurePen, StartPoint, FinishPoint);
        }
        public bool IsSelected(Point curentPoint)
        {
            throw new NotImplementedException();
        }

        public void Move(int deltaX, int deltaY)
        {
            throw new NotImplementedException();
        }
    }
}
