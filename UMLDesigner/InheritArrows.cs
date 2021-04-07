﻿using System.Drawing;
using System.Drawing.Drawing2D;

namespace UMLDesigner
{
    class InheritArrows : Arrow
    {
        public InheritArrows(Pen pen, Point start, Point finish) : base(pen, start, finish)
        {
            ArrowPen.CustomEndCap = new AdjustableArrowCap(10, 10);
        }

        public override void DrawArrow(Graphics graphics, Point start, Point finish)
        {
            FinishPoint = finish;
            graphics.DrawLine(ArrowPen, start, finish);
        }
    }
}
