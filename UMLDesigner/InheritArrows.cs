using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMLDesigner
{
    class InheritArrows : Arrow
    {
        public InheritArrows(Point start, Point finish): base(start, finish)
        {
            ArrowColor = Color.Green;
            Width = 5;
            Pen = new Pen(ArrowColor, Width);
            Pen.CustomEndCap = new AdjustableArrowCap(10, 10);
        }
    }
}
