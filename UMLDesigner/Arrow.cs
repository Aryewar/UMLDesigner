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
        public Point Start;
        public Point Finish;
        public Color ArrowColor;
        public int Width;
        public Pen Pen;

        protected LineCap _arrowCap;

        public Arrow(Point start, Point finish)
        {
            Start = start;
            Finish = finish;
        }
    }
}
