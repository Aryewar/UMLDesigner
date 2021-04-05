using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMLDesigner
{
    class RealizationArrows: Arrow
    {
        public RealizationArrows(Pen pen, Point start, Point finish) : base(pen, start, finish)
        {
            Pen.DashStyle = DashStyle.Dash;
            Pen.CustomEndCap = new AdjustableArrowCap(10, 10);
        }
    }
}
