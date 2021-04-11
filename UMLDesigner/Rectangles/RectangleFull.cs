using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMLDesigner
{
    class RectangleFull: AbstractRectangle
    {
        
        public RectangleFull(Pen pen, Point start) : base (pen, start)
        {
            _width = 120;
            _height = 30;
            StartPoint = start;
        }

        public override void DrawRectangle(Graphics graphics)
        {

            graphics.DrawRectangle(RectanglePen, StartPoint.X, StartPoint.Y, _width, _height);
        }
    }
}
