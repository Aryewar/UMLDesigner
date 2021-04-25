using System.Collections.Generic;
using System.Drawing;
using UMLDesigner.Figures.Rectangles;
using UMLDesigner.Figures.SinglePainter;

namespace UMLDesigner.Figures.Arrows
{
    public class AbstractArrow : IFigure
    {
        public Point StartPoint { get; set; }
        public Point FinishPoint { get; set; }
        public Point PrevPosition { get; set; }
        public Pen FigurePen { get; set; }
        public Font textFont { get; set; }
        public Port StartPort { get; set; }
        public Port FinishPort { get; set; }
        public List<IFigure> Links { get; set; }
        public string Type { get; set; }

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
            if (StartPort != null && FinishPort != null)
            {
                StartPoint = StartPort.ConnectingPoint;
                FinishPoint = FinishPort.ConnectingPoint;
            }

            if (StartPort.PortType == Painter.PortType.Bottom && FinishPort.PortType == Painter.PortType.Bottom)
            {
                DrawFromBottomToBottomCorner();
            }

            else if (StartPort.PortType == Painter.PortType.Right && FinishPort.PortType == Painter.PortType.Left)
            {
                DrawFromRightToLeftCorner();
            }

            else if (StartPort.PortType == Painter.PortType.Top && FinishPort.PortType == Painter.PortType.Top)
            {
                DrawFromTopToTopCorner();
            }

            else if (StartPort.PortType == Painter.PortType.Left && FinishPort.PortType == Painter.PortType.Right)
            {
                DrawFromLeftToRightCorner();
            }

            else if (StartPort.PortType == Painter.PortType.Right && FinishPort.PortType == Painter.PortType.Left)
            {
                DrawFromRightToLeftCorner();
            }

            else if (StartPort.PortType == Painter.PortType.Bottom && FinishPort.PortType == Painter.PortType.Left)
            {
                DrawFromBottomToLeftCorner();
            }

            else if (StartPort.PortType == Painter.PortType.Left && FinishPort.PortType == Painter.PortType.Bottom)
            {
                DrawFromLeftToBottomCorner();
            }

            else if (StartPort.PortType == Painter.PortType.Top && FinishPort.PortType == Painter.PortType.Right)
            {
                DrawFromTopToRigthCorner();
            }

            else if (StartPort.PortType == Painter.PortType.Top && FinishPort.PortType == Painter.PortType.Left)
            {
                DrawFromTopToLeftCorner();
            }

            else if (StartPort.PortType == Painter.PortType.Left && FinishPort.PortType == Painter.PortType.Top)
            {
                DrawFromLeftToTopCorner();
            }

            else if (StartPort.PortType == Painter.PortType.Top && FinishPort.PortType == Painter.PortType.Bottom)
            {
                DrawFromTopToBottomCorner();
            }

            else if (StartPort.PortType == Painter.PortType.Bottom && FinishPort.PortType == Painter.PortType.Top)
            {
                DrawFromBottomToTopCorner();
            }

            else if (StartPort.PortType == Painter.PortType.Right && FinishPort.PortType == Painter.PortType.Bottom)
            {
                DrawFromRightToBottomCorner();
            }

            else if (StartPort.PortType == Painter.PortType.Bottom && FinishPort.PortType == Painter.PortType.Right)
            {
                DrawFromBottomToRightCorner();
            }

            else if (StartPort.PortType == Painter.PortType.Right && FinishPort.PortType == Painter.PortType.Top)
            {
                DrawFromRightToTopCorner();
            }
        }
        public void DrawDirect()
        {
            _painter.PainterGraphics.DrawLine(FigurePen, StartPoint, FinishPoint);
        }

        public void DrawFromBottomToBottomCorner()
        {
            int middleY;
            if (StartPoint.Y < FinishPoint.Y)
            {
                middleY = (FinishPoint.Y + 30);
            }

            else
            {
                middleY = (StartPoint.Y + 30);
            }
            Point[] points =
            {
                 new Point(StartPoint.X, StartPoint.Y),
                 new Point(StartPoint.X, middleY),
                 new Point(FinishPoint.X, middleY),
                 new Point(FinishPoint.X, FinishPoint.Y)
            };

            _painter.PainterGraphics.DrawLines(FigurePen, points);
        }

        public void DrawFromTopToTopCorner()
        {
            int middleY;
            if (StartPoint.Y > FinishPoint.Y)
            {
                middleY = (FinishPoint.Y - 30);
            }

            else
            {
                middleY = (StartPoint.Y - 30);
            }
            Point[] points =
            {
                 new Point(StartPoint.X, StartPoint.Y),
                 new Point(StartPoint.X, middleY),
                 new Point(FinishPoint.X, middleY),
                 new Point(FinishPoint.X, FinishPoint.Y)
            };


            _painter.PainterGraphics.DrawLines(FigurePen, points);
        }

        public void DrawFromRightToLeftCorner()
        {
            int middleX = (FinishPoint.X + StartPoint.X) / 2;
            Point[] points =
            {
                 new Point(StartPoint.X, StartPoint.Y),
                 new Point(middleX, StartPoint.Y),
                 new Point(middleX, FinishPoint.Y),
                 new Point(FinishPoint.X, FinishPoint.Y)
            };

            _painter.PainterGraphics.DrawLines(FigurePen, points);
        }

        public void DrawFromLeftToRightCorner()
        {
            int middleX = (FinishPoint.X + StartPoint.X) / 2;
            Point[] points =
            {
                 new Point(StartPoint.X, StartPoint.Y),
                 new Point(middleX, StartPoint.Y),
                 new Point(middleX, FinishPoint.Y),
                 new Point(FinishPoint.X, FinishPoint.Y)
            };

            _painter.PainterGraphics.DrawLines(FigurePen, points);
        }

        public void DrawFromBottomToLeftCorner()
        {
            int middleX;
            int middleY;
            if (StartPoint.Y > FinishPoint.Y)
            {
                middleX = (FinishPoint.X + StartPoint.X) / 2;
                middleY = StartPoint.Y + 30;
                Point[] points =
                {
                 new Point(StartPoint.X, StartPoint.Y),
                 new Point(StartPoint.X, middleY),
                 new Point(middleX, middleY),
                 new Point(middleX, FinishPoint.Y),
                 new Point(FinishPoint.X, FinishPoint.Y)
                };
                _painter.PainterGraphics.DrawLines(FigurePen, points);
            }
            else
            {
                Point[] points =
                {
                 new Point(StartPoint.X, StartPoint.Y),
                 new Point(StartPoint.X, FinishPoint.Y),
                 new Point(FinishPoint.X, FinishPoint.Y)
                };
                _painter.PainterGraphics.DrawLines(FigurePen, points);
            }
        }

        public void DrawFromLeftToBottomCorner()
        {
            int middleX;
            int middleY;
            if (StartPoint.Y > FinishPoint.Y)
            {
                middleX = (FinishPoint.X + StartPoint.X) / 2;
                middleY = StartPoint.Y + 30;
                Point[] points =
                {
                 new Point(StartPoint.X, StartPoint.Y),
                 new Point(StartPoint.X, middleY),
                 new Point(middleX, middleY),
                 new Point(middleX, FinishPoint.Y),
                 new Point(FinishPoint.X, FinishPoint.Y)
                };
                _painter.PainterGraphics.DrawLines(FigurePen, points);
            }
            else
            {
                Point[] points =
                {
                 new Point(StartPoint.X, StartPoint.Y),
                 new Point(StartPoint.X, FinishPoint.Y),
                 new Point(FinishPoint.X, FinishPoint.Y)
                };
                _painter.PainterGraphics.DrawLines(FigurePen, points);
            }
        }

        public void DrawFromTopToRigthCorner()
        {
            int middleX;
            int middleY;

            middleX = FinishPoint.X + 30;
            middleY = StartPoint.Y - 50;
            Point[] points =
            {
                 new Point(StartPoint.X, StartPoint.Y),
                 new Point(StartPoint.X, middleY),
                 new Point(middleX, middleY),
                 new Point(middleX, FinishPoint.Y),
                 new Point(FinishPoint.X, FinishPoint.Y)
                };
            _painter.PainterGraphics.DrawLines(FigurePen, points);
        }

        public void DrawFromTopToLeftCorner()
        {
            int middleX;
            int middleY;

            middleX = (FinishPoint.X + StartPoint.X) / 2;
            middleY = StartPoint.Y - 30;
            Point[] points =
                {
                 new Point(StartPoint.X, StartPoint.Y),
                 new Point(StartPoint.X, middleY),
                 new Point(middleX, middleY),
                 new Point(middleX, FinishPoint.Y),
                 new Point(FinishPoint.X, FinishPoint.Y)
                };
            _painter.PainterGraphics.DrawLines(FigurePen, points);
        }

        public void DrawFromLeftToTopCorner()
        {
            int middleX;
            int middleY;

            middleX = (StartPoint.X + FinishPoint.X) / 2;
            middleY = FinishPoint.Y -30;
            Point[] points =
                {
                 new Point(StartPoint.X, StartPoint.Y),
                 new Point(middleX, StartPoint.Y),
                 new Point(middleX, middleY),
                 new Point(FinishPoint.X, middleY),
                 new Point(FinishPoint.X, FinishPoint.Y)
                };
            _painter.PainterGraphics.DrawLines(FigurePen, points);
        }

        public void DrawFromTopToBottomCorner()
        {
            int middleX;
            int middleY;
            int SecondPointY;

            SecondPointY = StartPoint.Y - 30;
            middleX = (StartPoint.X + FinishPoint.X) / 2;
            middleY = FinishPoint.Y + 30;
            Point[] points =
                {
                 new Point(StartPoint.X, StartPoint.Y),
                 new Point(StartPoint.X, SecondPointY),
                 new Point(middleX, SecondPointY),
                 new Point(middleX, middleY),
                 new Point(FinishPoint.X, middleY),
                 new Point(FinishPoint.X, FinishPoint.Y)
                };
            _painter.PainterGraphics.DrawLines(FigurePen, points);
        }

        public void DrawFromBottomToTopCorner()
        {
            int middleX;
            int middleY;
            int SecondPointY;

            SecondPointY = StartPoint.Y + 30;
            middleX = (StartPoint.X + FinishPoint.X) / 2;
            middleY = FinishPoint.Y - 30;
            Point[] points =
                {
                 new Point(StartPoint.X, StartPoint.Y),
                 new Point(StartPoint.X, SecondPointY),
                 new Point(middleX, SecondPointY),
                 new Point(middleX, middleY),
                 new Point(FinishPoint.X, middleY),
                 new Point(FinishPoint.X, FinishPoint.Y)
                };
            _painter.PainterGraphics.DrawLines(FigurePen, points);
        }

        public void DrawFromRightToBottomCorner()
        {
            int middleX;
            int middleY;

            middleX = (StartPoint.X + FinishPoint.X) / 2;
            middleY = FinishPoint.Y + 30;
            Point[] points =
                {
                 new Point(StartPoint.X, StartPoint.Y),
                 new Point(middleX, StartPoint.Y),
                 new Point(middleX, middleY),
                 new Point(FinishPoint.X, middleY),
                 new Point(FinishPoint.X, FinishPoint.Y)
                };
            _painter.PainterGraphics.DrawLines(FigurePen, points);
        }

        public void DrawFromBottomToRightCorner()
        {
                int middleX;
                int middleY;

                middleX = (StartPoint.X + FinishPoint.X) / 2;
                middleY = StartPoint.Y + 30;
                Point[] points =
                {
                 new Point(StartPoint.X, StartPoint.Y),
                 new Point(StartPoint.X, middleY),
                 new Point(middleX, middleY),
                 new Point(middleX, FinishPoint.Y),
                 new Point(FinishPoint.X, FinishPoint.Y)
                };
                _painter.PainterGraphics.DrawLines(FigurePen, points);
        }

        public void DrawFromRightToTopCorner()
        {
            int middleX;
            int middleY;

            middleX = StartPoint.X + 30;
            middleY = FinishPoint.Y - 30;
            Point[] points =
            {
                 new Point(StartPoint.X, StartPoint.Y),
                 new Point(middleX, StartPoint.Y),
                 new Point(middleX, middleY),
                 new Point(FinishPoint.X, middleY),
                 new Point(FinishPoint.X, FinishPoint.Y)
                };
            _painter.PainterGraphics.DrawLines(FigurePen, points);
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
