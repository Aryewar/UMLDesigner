using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMLDesigner
{
    public abstract class Arrow
    {
        public Point StartPoint { get; set; }
        public Point FinishPoint { get; set; }
        public Pen ArrowPen { get; protected set; }

        public Arrow(Pen pen, Point start, Point finish)
        {
            StartPoint = start;
            FinishPoint = finish;
            ArrowPen = new Pen(pen.Color, pen.Width);
        }

        public abstract void DrawArrow(Graphics graphics, Point start, Point finish);
    }
}
