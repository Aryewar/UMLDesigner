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

        public void MouseDown(MouseEventArgs e, ref IFigure curentFigure, IFigureFabric fabric, List<IFigure> figures)
        {
            curentFigure = fabric.GetFigure();
            AbstractArrow curentArrow = (AbstractArrow)curentFigure;

            foreach (IFigure a in figures)
            {
                if (a is ClassRectangle)
                {
                    ClassRectangle temp = (ClassRectangle)a;
                    foreach (Port b in temp.Ports)
                    {
                        if(b.SelectedPort(e.Location) 
                            && (b.ArrowType is null || b.ArrowType == curentFigure.GetType())
                           )
                        {
                            curentArrow.StartPort = b;
                            curentFigure.StartPoint = b.ConnectingPoint;
                            curentArrow.Links.Add(a);
                            break;
                        }
                    }
                }
            }

            if(curentArrow.StartPort is null)
            {
                curentFigure = null;
            }
        }

        public void MouseMove(MouseEventArgs e, IFigure curentFigure)
        {
            curentFigure.FinishPoint = e.Location;
            _painter.UpdatePictureBox();
            curentFigure.Draw();
            GC.Collect();
        }

        public void MouseUp(MouseEventArgs e, ref IFigure curentFigure, List<IFigure> figures)
        {
            AbstractArrow curentArrow = (AbstractArrow)curentFigure;

            foreach (IFigure a in figures)
            {
                if (a is ClassRectangle)
                {
                    ClassRectangle temp = (ClassRectangle)a;

                    foreach (Port b in temp.Ports)
                    {
                        if (b.SelectedPort(e.Location)
                            && (b.ArrowType is null || b.ArrowType == curentFigure.GetType())
                           )
                        {
                            curentArrow.FinishPort = b;
                            curentFigure.FinishPoint = b.ConnectingPoint;
                            curentFigure.Links.Add(a);
                            break;
                        }
                    }
                }
            }

            if(curentArrow.FinishPort != null)
            {
                _painter.SetMainBitmap();
                figures.Add(curentFigure);
                foreach(IFigure a in curentFigure.Links)
                {
                    a.Links.Add(curentFigure);
                }
                curentArrow.StartPort.ArrowType = curentArrow.GetType();
                curentArrow.FinishPort.ArrowType = curentArrow.GetType();
                curentFigure = null;
            }
            else
            {
                _painter.UpdatePictureBox();
                curentFigure = null;
            }
        }

        public void MouseDoubleClick(MouseEventArgs e, ref IFigure curentFigure, List<IFigure> figures, ClassDialogForm _classDialogForm)
        {

        }
    }
}
