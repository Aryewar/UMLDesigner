﻿using System.Drawing;

namespace UMLDesigner
{
    public abstract class AbstractRectangle
    {
        public Point StartPoint { get; set; }
        public Point FinishPoint { get; set; }
        public Pen ArrowPen { get; protected set; }

        public AbstractRectangle(Pen pen, Point start, Point finish)
        {
            StartPoint = start;
            FinishPoint = finish;
            ArrowPen = new Pen(pen.Color, pen.Width);
        }

        public abstract void DrawRectangle(Graphics graphics, Point start, Point finish);
    }
}
