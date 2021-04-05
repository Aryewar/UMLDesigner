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
        public Point Start { get; set; }
        public Point Finish { get; set; }
        public Pen Pen { get; protected set; }

        public Arrow(Pen pen, Point start, Point finish)
        {
            Start = start;
            Finish = finish;
            Pen = new Pen(pen.Color, pen.Width);
        }

        //public abstract void DrawArrow(Pen pen, Point start, Point finish);
    }
}
