using System;
using System.Drawing;

namespace UMLDesigner.Figures.Rectangles
{
    public class Port
    {
        public Point ConnectingPoint { get; set; }
        public Type ArrowType { get; set; }
        public int PointWidth { get; set; }

        public Port()
        {
            ArrowType = null;
            PointWidth = 0;
        }

        public bool SelectedPort(Point currentPoint)
        {
            if((currentPoint.X >= ConnectingPoint.X - PointWidth
               && currentPoint.X <= ConnectingPoint.X + PointWidth
               && currentPoint.Y >= ConnectingPoint.Y - PointWidth
               && currentPoint.Y <= ConnectingPoint.Y + PointWidth))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
