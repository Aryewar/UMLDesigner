using System;
using System.Collections.Generic;
using System.Windows.Forms;
using UMLDesigner.Figures;
using UMLDesigner.Figures.Fabrics;
using UMLDesigner.Figures.Rectangles;
using UMLDesigner.Figures.SinglePainter;
using UMLDesigner.Figures.Arrows;

namespace UMLDesigner.MouseHandler
{
    public class DrawArrowMouseHandler : IMouseHandler
    {
        private Painter _painter = Painter.GetPainter();

        public void MouseDown(object sender, MouseEventArgs e)
        {
            _painter.CurentFigure = _painter.Fabric.GetFigure();
            AbstractArrow curentArrow = (AbstractArrow)_painter.CurentFigure;

            foreach (IFigure a in _painter.Figures)
            {
                if (a is ClassRectangle)
                {
                    ClassRectangle temp = (ClassRectangle)a;
                    foreach (Port b in temp.Ports)
                    {
                        if(b.SelectedPort(e.Location) 
                            && (b.ArrowType is null || b.ArrowType == _painter.CurentFigure.GetType())
                           )
                        {
                            curentArrow.StartPort = b;
                            _painter.CurentFigure.StartPoint = b.ConnectingPoint;
                            curentArrow.Links.Add(a);
                            break;
                        }
                    }
                }
            }

            if(curentArrow.StartPort is null)
            {
                _painter.CurentFigure = null;
            }
        }

        public void MouseMove(object sender, MouseEventArgs e)
        {
            _painter.CurentFigure.FinishPoint = e.Location;
            _painter.UpdatePictureBox();
            _painter.CurentFigure.Draw();
            GC.Collect();
        }

        public void MouseUp(object sender, MouseEventArgs e)
        {
            AbstractArrow curentArrow = (AbstractArrow)_painter.CurentFigure;

            foreach (IFigure a in _painter.Figures)
            {
                if (a is ClassRectangle)
                {
                    ClassRectangle temp = (ClassRectangle)a;

                    foreach (Port b in temp.Ports)
                    {
                        if (b.SelectedPort(e.Location)
                            && (b.ArrowType is null || b.ArrowType == _painter.CurentFigure.GetType())
                           )
                        {
                            curentArrow.FinishPort = b;
                            _painter.CurentFigure.FinishPoint = b.ConnectingPoint;
                            _painter.CurentFigure.Links.Add(a);
                            break;
                        }
                    }
                }
            }

            if(curentArrow != null && curentArrow.FinishPort != null)
            {
                _painter.SetMainBitmap();
                _painter.Figures.Add(_painter.CurentFigure);
                foreach(IFigure a in _painter.CurentFigure.Links)
                {
                    a.Links.Add(_painter.CurentFigure);
                }
                curentArrow.StartPort.ArrowType = curentArrow.GetType();
                curentArrow.FinishPort.ArrowType = curentArrow.GetType();
                _painter.CurentFigure = null;
            }
            else
            {
                _painter.UpdatePictureBox();
                _painter.CurentFigure = null;
            }
        }

        public void MouseDoubleClick(object sender, MouseEventArgs e, ClassDialogForm _classDialogForm)
        {
        }
    }
}
