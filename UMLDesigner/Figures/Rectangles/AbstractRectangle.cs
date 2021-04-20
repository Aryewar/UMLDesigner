using System;
using System.Drawing;
using System.Text;
using UMLDesigner.Figures.SinglePainter;

namespace UMLDesigner.Figures.Rectangles
{
    public abstract class AbstractRectangle : IFigure
    {
        public Point StartPoint { get; set; }
        public Point FinishPoint { get; set; }
        public Pen FigurePen { get; set; }
        public SolidBrush FigureBackColor { get; set; }
        public int Width { get; protected set; }
        public int Height { get; protected set; }
        public StringBuilder Title { get; set; }
        public StringBuilder Properties { get; set; }
        public StringBuilder Fields { get; set; }
        public StringBuilder Methods { get; set; }
        public Font textFont { get; set; }

        public Point PrevPosition;


        protected Painter _painter;
        private SizeF[] _textSize;
        private int _startPropertiesPointY;
        private int _startFieldsPointY;
        private int _startMethodsPointY;


        public AbstractRectangle()
        {
            Width = 0;
            Height = 0;
            Title = new StringBuilder("Title");
            Properties = new StringBuilder("Properties");
            Fields = new StringBuilder("Fields");
            Methods = new StringBuilder("Methods");
            _painter = Painter.GetPainter();
            _textSize = new SizeF[4];
            textFont = new Font("Ariel", 14);
        }
        public void Draw()
        {
            MeasureText();

            _painter.PainterGraphics.FillRectangle(FigureBackColor, StartPoint.X, StartPoint.Y, Width, Height);

            _painter.PainterGraphics.DrawString(Title.ToString(), textFont, new SolidBrush(FigurePen.Color), StartPoint.X, StartPoint.Y);
            _painter.PainterGraphics.DrawString(Properties.ToString(), textFont, new SolidBrush(FigurePen.Color), StartPoint.X, _startPropertiesPointY);
            _painter.PainterGraphics.DrawString(Fields.ToString(), textFont, new SolidBrush(FigurePen.Color), StartPoint.X, _startFieldsPointY);
            _painter.PainterGraphics.DrawString(Methods.ToString(), textFont, new SolidBrush(FigurePen.Color), StartPoint.X, _startMethodsPointY);

            _painter.PainterGraphics.DrawRectangle(FigurePen, StartPoint.X, StartPoint.Y, Width, Height);
            _painter.PainterGraphics.DrawLine(FigurePen, StartPoint.X, _startPropertiesPointY, StartPoint.X + Width, _startPropertiesPointY);
            _painter.PainterGraphics.DrawLine(FigurePen, StartPoint.X, _startFieldsPointY, StartPoint.X + Width, _startFieldsPointY);
            _painter.PainterGraphics.DrawLine(FigurePen, StartPoint.X, _startMethodsPointY, StartPoint.X + Width, _startMethodsPointY);

        }

        public void MeasureText()
        {
            Height = 0;
            Width = 0;

            _textSize[0] = _painter.PainterGraphics.MeasureString(Title.ToString(), textFont);
            _textSize[1] = _painter.PainterGraphics.MeasureString(Properties.ToString(), textFont);
            _textSize[2] = _painter.PainterGraphics.MeasureString(Fields.ToString(), textFont);
            _textSize[3] = _painter.PainterGraphics.MeasureString(Methods.ToString(), textFont);

            _startPropertiesPointY = (int)(StartPoint.Y + _textSize[0].Height);
            _startFieldsPointY = (int)(StartPoint.Y + _textSize[0].Height + _textSize[1].Height);
            _startMethodsPointY = (int)(StartPoint.Y + _textSize[0].Height + _textSize[1].Height + _textSize[2].Height);

            for(int i = 0; i < _textSize.Length; ++i)
            {
                Height += (int) _textSize[i].Height + 1;

                if(Width < _textSize[i].Width)
                {
                    Width = (int) _textSize[i].Width + 5;
                }
            }
        }

        public bool IsSelected(Point currentPoint)
        {
            FinishPoint = new Point(StartPoint.X + Width, StartPoint.Y + Height);
            
            if (currentPoint.X >= StartPoint.X && currentPoint.X <= FinishPoint.X
                && currentPoint.Y >= StartPoint.Y && currentPoint.Y <= FinishPoint.Y)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Move(Point currentPoint)
        {
            int deltaX = currentPoint.X - PrevPosition.X;
            int deltaY = currentPoint.Y - PrevPosition.Y;
            StartPoint = new Point(StartPoint.X + deltaX, StartPoint.Y + deltaY);
            PrevPosition = currentPoint;
        }
    }
}
