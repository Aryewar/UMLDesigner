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
        public InheritArrows(Pen pen, Point start, Point finish) : base(pen, start, finish)
        {
            Pen.CustomEndCap = new AdjustableArrowCap(10, 10);
        }
    }
}
