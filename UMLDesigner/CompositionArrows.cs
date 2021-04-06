using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMLDesigner
{
    class CompositionArrows: Arrow
    {
        public CompositionArrows(Pen pen, Point start, Point finish) : base(pen, start, finish)
        {
            Pen.CustomEndCap = new AdjustableArrowCap(50, 50);
        }

        public override void DrawArrow(Graphics graphics, Point start, Point finish)
        {
            FinishPoint = finish;
            Pen.EndCap = LineCap.DiamondAnchor;
            graphics.DrawLine(Pen, start, finish);
        }
    }
}
