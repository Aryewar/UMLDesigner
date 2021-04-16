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

        protected Painter _painter = Painter.GetPainter();

        public void Draw()
        {
            FigurePen.Color = _painter.PainterPen.Color;
            FigurePen.Width = _painter.PainterPen.Width;
            _painter.PainterGraphics.DrawLine(FigurePen, StartPoint, FinishPoint);
        }
        public bool IsSelected(Point currentPoint)
        {
            throw new NotImplementedException();
        }

        public void Move(int deltaX, int deltaY)
        {
            throw new NotImplementedException();
        }
    }
}
