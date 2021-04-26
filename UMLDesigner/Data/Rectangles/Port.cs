using System;
using System.Drawing;
using static UMLDesigner.Figures.SinglePainter.Painter;

namespace UMLDesigner.Figures.Rectangles
{
    public class Port
    {
        public Point ConnectingPoint { get; set; }
        public FigureType ArrowType { get; set; }
        public int PointWidth { get; set; }
        public PortType PortType { get; set; }
        public Port()
        {
            PointWidth = 0;
        }

        public bool SelectedPort(Point currentPoint)
        {
            if((currentPoint.X >= ConnectingPoint.X - PointWidth-5
               && currentPoint.X <= ConnectingPoint.X + PointWidth+5
               && currentPoint.Y >= ConnectingPoint.Y - PointWidth-5
               && currentPoint.Y <= ConnectingPoint.Y + PointWidth+5))
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
