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
        public RealizationArrows(Point start, Point finish) : base(start, finish)
        {
            ArrowColor = Color.Red;
            Width = 8;
            Pen = new Pen(ArrowColor, Width);
            Pen.DashStyle = DashStyle.Dash;
            Pen.CustomEndCap = new AdjustableArrowCap(10, 10);
        }
    }
}
