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
            bool isSelected = false;
            AbstractArrow curentArrow = (AbstractArrow)curentFigure;

            foreach (IFigure a in figures)
            {
                if (a is ClassRectangle)
                {
                    ClassRectangle temp = (ClassRectangle)a;
                    foreach (Port b in temp.Ports)
                    {
                        if(b.SelectedPort(e.Location))
                        {
                            b.isTaken = true;
                            b.ArrowType = curentFigure.GetType();
                            curentArrow.StartPort = b;
                            curentArrow.StartPoint = curentArrow.StartPort.ConnectingPoint;
                            isSelected = true;
                            curentArrow.Links.Add(a);
                            break;
                        }
                    }
                }
            }

            if(!isSelected)
            {
                curentFigure = null;
            }
        }

        public void MouseMove(MouseEventArgs e, IFigure curentFigure)
        {
            AbstractArrow curentArrow = (AbstractArrow)curentFigure;
            curentArrow.FinishPort.ConnectingPoint = e.Location;
            _painter.UpdatePictureBox();
            curentFigure.Draw();
            GC.Collect();
        }

        public void MouseUp(MouseEventArgs e, ref IFigure curentFigure, List<IFigure> figures)
        {
            bool isSelected = false;
            AbstractArrow curentArrow = (AbstractArrow)curentFigure;

            foreach (IFigure a in figures)
            {
                if (a is ClassRectangle)
                {
                    ClassRectangle temp = (ClassRectangle)a;
                    foreach (Port b in temp.Ports)
                    {
                        if (b.SelectedPort(e.Location))
                        {
                            curentArrow.FinishPort = b;
                            curentArrow.FinishPoint = curentArrow.FinishPort.ConnectingPoint;
                            b.isTaken = true;
                            b.ArrowType = curentFigure.GetType();
                            isSelected = true;
                            curentFigure.Links.Add(a);
                            break;
                        }
                    }
                }
            }

            if(isSelected)
            {
                _painter.SetMainBitmap();
                figures.Add(curentFigure);
                foreach(IFigure a in curentFigure.Links)
                {
                    a.Links.Add(curentFigure);
                }
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
