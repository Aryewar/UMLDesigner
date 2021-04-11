using System.Drawing;
using UMLDesigner.Rectangles;

namespace UMLDesigner
{
    public abstract class AbstractRectangle:IRectangleMoveable
    {
        public Point StartPoint { get; set; }
        public Pen RectanglePen { get; protected set; }

        public int _width { get; set; }
        public int _height { get; set; }

        public AbstractRectangle(Pen pen, Point start)
        {
            StartPoint = start;
            RectanglePen = new Pen(pen.Color, pen.Width);
        }

        public abstract void DrawRectangle(Graphics graphics);

        public bool IsSelected (Point point)
        {
            int finishX = StartPoint.X + _width;
            int finishY = StartPoint.Y - _height;
            if (point.X >= StartPoint.X && point.X <= finishX
                && point.Y <= StartPoint.Y && point.Y >= finishY)
            {
                return true;
            } else
            {
                return false;
            }
        }

        public void Move (int deltaX, int deltaY)
        {
            StartPoint = new Point(StartPoint.X + deltaX, StartPoint.Y + deltaY);
        }
    }
}
