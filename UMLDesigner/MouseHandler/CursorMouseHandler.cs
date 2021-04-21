using System;
using System.Collections.Generic;
using System.Windows.Forms;
using UMLDesigner.Figures;
using UMLDesigner.Figures.Fabrics;
using UMLDesigner.Figures.Rectangles;
using UMLDesigner.Figures.SinglePainter;

namespace UMLDesigner.MouseHandler
{
    public class CursorMouseHandler : IMouseHandler
    {
        private Painter _painter = Painter.GetPainter();
        public void MouseDown(MouseEventArgs e)
        {
            foreach (IFigure a in _painter.Figures)
            {
                if (a.IsSelected(e.Location))
                {
                   _painter.CurentFigure = a;
                    break;
                }
            }
            if (_painter.CurentFigure != null)
            {
                _painter.CurentFigure.PrevPosition = e.Location;
                _painter.Clear();
                foreach (IFigure a in _painter.Figures)
                {
                    if (_painter.CurentFigure != a && !_painter.CurentFigure.Links.Contains(a))
                    {
                        a.Draw();
                    }
                }

                _painter.SetMainBitmap();
                MouseMove(e);
            }
        }

        public void MouseMove(MouseEventArgs e)
        {
            _painter.UpdatePictureBox();
            _painter.CurentFigure.Move(e.Location);
            _painter.CurentFigure.Draw();
            GC.Collect();
        }

        public void MouseUp(MouseEventArgs e)
        {
            _painter.SetMainBitmap();
            _painter.CurentFigure = null;
        }
        public void MouseDoubleClick(MouseEventArgs e, ClassDialogForm _classDialogForm)
        {
            foreach (IFigure a in _painter.Figures)
            {
                if (a.IsSelected(e.Location))
                {
                    _painter.CurentFigure = a;
                    break;
                }
            }
            if (_painter.CurentFigure is ClassRectangle)
            {
                _classDialogForm.OpenCurrentFigure((ClassRectangle)_painter.CurentFigure);
            }
        }
    }
}
