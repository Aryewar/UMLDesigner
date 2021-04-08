using System.Drawing;
using System.Drawing.Drawing2D;

namespace UMLDesigner
{
    class AssociationArrows: AbstractArrow
    {
        public AssociationArrows(Pen pen, Point start, Point finish) : base(pen, start, finish)
        {
            ArrowPen.CustomEndCap = new AdjustableArrowCap(10, 10, false);
        }

        public override void DrawArrow(Graphics graphics, Point start, Point finish)
        {
            FinishPoint = finish;
            StartPoint = start;
            graphics.DrawLine(ArrowPen, start, finish);
        }
    }
}
