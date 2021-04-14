using System;
using System.Drawing;
using UMLDesigner.Figures.SinglePainter;

namespace UMLDesigner.Figures.Rectangles
{
    public abstract class AbstractRectangle : IFigure
    {
        public Point StartPoint { get; set; }
        public Point FinishPoint { get; set; }
        public Pen FigurePen { get; set; }
        public int Width { get; protected set; }
        public int Height { get; protected set; }
        protected Painter _painter = Painter.GetPainter();

        public AbstractRectangle()
        {
            Width = 120;
            Height = 30;
        }
        public void Draw()
        {
            _painter.PainterGraphics.DrawRectangle(FigurePen, StartPoint.X, StartPoint.Y, Width, Height);
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
