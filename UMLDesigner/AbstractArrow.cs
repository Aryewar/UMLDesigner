using System.Drawing;

namespace UMLDesigner
{
    public abstract class AbstractArrow: IMovableArrow
    {
        private int _deltaXY = 10;
        public bool EndArrow { get; private set; }
        public bool StrartArrow { get; private set; }
        public Point StartPoint { get; set; }
        public Point FinishPoint { get; set; }
        public Pen ArrowPen { get; protected set; }
        public enum Arrows
        {
            CompositionArrows,
            AgragationArrows,
            AssociationArrows,
            InheritArrows,
            RealizationArrows
        }

        public AbstractArrow(Pen pen, Point start, Point finish)
        {
            EndArrow = false;
            StrartArrow = false;
            StartPoint = start;
            FinishPoint = finish;
            ArrowPen = new Pen(pen.Color, pen.Width);
        }

        public abstract void DrawArrow(Graphics graphics, Point start, Point finish);

        public void IsItEndArrow(Point currentPoint)
        {
            if(currentPoint.X >= FinishPoint.X - _deltaXY 
               && currentPoint.X <= FinishPoint.X + _deltaXY
               && currentPoint.Y >= FinishPoint.Y - _deltaXY
               && currentPoint.Y <= FinishPoint.Y + _deltaXY)
            {
                EndArrow  = true;
            }
            else
            {
                EndArrow = false;
            }
        }

        public void IsItStartArrow(Point currentPoint)
        {
            if (currentPoint.X >= StartPoint.X - _deltaXY
               && currentPoint.X <= StartPoint.X + _deltaXY
               && currentPoint.Y >= StartPoint.Y - _deltaXY
               && currentPoint.Y <= StartPoint.Y + _deltaXY)
            {
                StrartArrow = true;
            }
            else
            {
                StrartArrow = false;
            }
        }

        public void MoveArrowCup(Graphics graphics, Point currentPoint)
        {
            if(EndArrow)
            {
                this.DrawArrow(graphics, StartPoint, currentPoint);
            }
            else if(StrartArrow)
            {
                this.DrawArrow(graphics, currentPoint, FinishPoint);
            }
        }
    }
}
