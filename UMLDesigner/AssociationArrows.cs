using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMLDesigner
{
    class AssociationArrows: Arrow
    {
        public AssociationArrows(Point start, Point finish) : base(start, finish)
        {
            ArrowColor = Color.Black;
            Width = 3;
            Pen = new Pen(ArrowColor, Width);
            Pen.CustomEndCap = new AdjustableArrowCap(10, 10, false);
        }
    }
}
