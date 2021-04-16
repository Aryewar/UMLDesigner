using System.Drawing;
using UMLDesigner.Figures.SinglePainter;

namespace UMLDesigner.Figures.Arrows
{
    public class AbstractArrow : IFigure
    {
        public Point StartPoint { get; set; }
        public Point FinishPoint { get; set; }
        public Pen FigurePen { get; set; }
        public Font textFont { get; set; }

        private bool _selectedEnd;
        private bool _selectedStart;
        private int _deltaXY = 10;
        protected Painter _painter;

        public AbstractArrow()
        {
            _selectedEnd = false;
            _selectedStart = false;
            _painter = Painter.GetPainter();
        }

        public void Draw()
        {
            _painter.PainterGraphics.DrawLine(FigurePen, StartPoint, FinishPoint);
        }
        public bool IsSelected(Point currentPoint)
        {
            if (currentPoint.X >= FinishPoint.X - _deltaXY
              && currentPoint.X <= FinishPoint.X + _deltaXY
              && currentPoint.Y >= FinishPoint.Y - _deltaXY
              && currentPoint.Y <= FinishPoint.Y + _deltaXY)
            {
                _selectedStart = false;
                _selectedEnd = true;
                return _selectedEnd;
            }
            else if (currentPoint.X >= StartPoint.X - _deltaXY
               && currentPoint.X <= StartPoint.X + _deltaXY
               && currentPoint.Y >= StartPoint.Y - _deltaXY
               && currentPoint.Y <= StartPoint.Y + _deltaXY)
            {
                _selectedStart = true;
                _selectedEnd = false;
                return _selectedStart;
            }
            else
            {
                _selectedStart = false;
                _selectedEnd = false;
                return _selectedStart;
            }
        }

        public void Move(Point currentPoint)
        {
            if (_selectedStart)
            {
                StartPoint = currentPoint;
            }
            else if (_selectedEnd)
            {
               FinishPoint = currentPoint;
            }
        }
    }
}
