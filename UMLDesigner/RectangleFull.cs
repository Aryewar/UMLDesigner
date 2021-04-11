using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMLDesigner
{
    class RectangleFull: AbstractRectangle
    {
        public RectangleFull(Pen pen, Point start, Point finish) : base(pen, start, finish)
        {
            
        }

        public override void DrawRectangle(Graphics graphics, Point start, Point finish)
        {
            Point[] coordinates = new Point[]
            {
                start,
                new Point(finish.X, start.Y),
                finish,
                new Point(start.X, finish.Y)
            };
            graphics.DrawPolygon(ArrowPen, coordinates);
            graphics.Dispose();
        }
    }
}
