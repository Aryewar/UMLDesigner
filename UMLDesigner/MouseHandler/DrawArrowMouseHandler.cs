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
                            && (b.ArrowType == Painter.FigureType.NoDefine || b.ArrowType == _painter.CurentFigure.figureType)
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
            AbstractArrow curentArrow = (AbstractArrow)_painter.CurentFigure;

            _painter.CurentFigure.FinishPoint = e.Location;
            _painter.UpdatePictureBox();
            curentArrow.DrawDirect();
            GC.Collect();
        }

        public void MouseUp(object sender, MouseEventArgs e)
        {
            AbstractArrow curentArrow = (AbstractArrow)_painter.CurentFigure;
            _painter.UpdatePictureBox();
            if (curentArrow != null)
            {
                foreach (IFigure a in _painter.Figures)
                {
                    if (a is ClassRectangle)
                    {
                        ClassRectangle temp = (ClassRectangle)a;

                        foreach (Port b in temp.Ports)
                        {
                            if (b.SelectedPort(e.Location)
                                && (b.ArrowType == Painter.FigureType.NoDefine || b.ArrowType == _painter.CurentFigure.figureType)
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

                if (curentArrow.FinishPort != null)
                {
                    _painter.CurentFigure.Draw();
                    _painter.SetMainBitmap();
                    _painter.Figures.Add(_painter.CurentFigure);
                    foreach (IFigure a in _painter.CurentFigure.Links)
                    {
                        a.Links.Add(_painter.CurentFigure);
                    }
                    curentArrow.FinishPort.ArrowType = curentArrow.figureType;
                    curentArrow.StartPort.ArrowType = curentArrow.figureType;
                    _painter.CurentFigure = null;
                    _painter.UpdatePictureBox();
                }
            }
        }

        public void MouseDoubleClick(object sender, MouseEventArgs e, ClassDialogForm _classDialogForm)
        {
        }
    }
}
