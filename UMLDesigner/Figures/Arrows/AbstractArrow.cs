using System.Collections.Generic;
using System.Drawing;
using System.Text.Json.Serialization;
using UMLDesigner.Figures.Rectangles;
using UMLDesigner.Figures.SinglePainter;
using static UMLDesigner.Figures.SinglePainter.Painter;

namespace UMLDesigner.Figures.Arrows
{
    public class AbstractArrow : IFigure
    {
        public Point StartPoint { get; set; }
        public Point FinishPoint { get; set; }
        public Point PrevPosition { get; set; }
        [JsonIgnore]
        public Pen FigurePen { get; set; }
        public int PenWidth { get; set; }
        public Color PenColor { get; set; }
        public Font textFont { get; set; }
        public Port StartPort { get; set; }
        public Port FinishPort { get; set; }
        public FigureType figureType { get; set;}
        public List<IFigure> Links { get; set; }

        private bool _selectedEnd;
        private bool _selectedStart;
        private int _deltaXY = 10;
        protected Painter _painter;

        public AbstractArrow()
        {
            _selectedEnd = false;
            _selectedStart = false;
            _painter = Painter.GetPainter();
            Links = new List<IFigure>();
        }

        public void Draw()
        {
            if(StartPort != null && FinishPort != null)
            {
                StartPoint = StartPort.ConnectingPoint;
                FinishPoint = FinishPort.ConnectingPoint;
                //StartPoint = ((ClassRectangle)Links[0]).Ports[0].ConnectingPoint;
                //StartPoint = ((ClassRectangle)Links[1]).Ports[0].ConnectingPoint;
            }

            _painter.PainterGraphics.DrawLine(FigurePen, StartPoint, FinishPoint);
        }

        public bool IsSelected(Point currentPoint)
        {
            return false;
        }

        public void Move(Point currentPoint)
        {
        }
    }
}
