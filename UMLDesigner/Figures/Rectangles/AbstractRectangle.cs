using System;
using System.Drawing;
using System.Text;
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
        public StringBuilder Title { get; set; }
        public StringBuilder Properties { get; set; }
        public StringBuilder Fields { get; set; }
        public StringBuilder Methods { get; set; }

        protected Painter _painter;

        public AbstractRectangle()
        {
            Width = 120;
            Height = 30;
            Title = new StringBuilder();
            Properties = new StringBuilder();
            Fields = new StringBuilder();
            Methods = new StringBuilder();
            _painter = Painter.GetPainter();
        }
        public void Draw()
        {
            _painter.PainterGraphics.DrawRectangle(FigurePen, StartPoint.X, StartPoint.Y, Width, Height);
        }

        public bool IsSelected(Point currentPoint)
        {
            FinishPoint = new Point(StartPoint.X + Width, StartPoint.Y + Height);
            
            if (currentPoint.X >= StartPoint.X && currentPoint.X <= FinishPoint.X
                && currentPoint.Y >= StartPoint.Y && currentPoint.Y <= FinishPoint.Y)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Move(int deltaX, int deltaY)
        {
            StartPoint = new Point(StartPoint.X + deltaX, StartPoint.Y + deltaY);
        }
    }
}
