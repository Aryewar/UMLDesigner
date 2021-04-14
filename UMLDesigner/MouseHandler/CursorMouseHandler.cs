using System;
using System.Collections.Generic;
using System.Windows.Forms;
using UMLDesigner.Figures;
using UMLDesigner.Figures.Fabrics;
using UMLDesigner.Figures.SinglePainter;

namespace UMLDesigner.MouseHandler
{
    public class CursorMouseHandler : IMouseHandler
    {
        private Painter _painter = Painter.GetPainter();
        public void MouseDown(MouseEventArgs e,ref IFigure curentFigure, IFigureFabric fabric, List<IFigure> figures)
        {
            
            foreach (IFigure a in figures)
            {
                if (a.IsSelected(e.Location))
                {
                    curentFigure = a;
                    break;
                }
            }
            if (curentFigure != null)
            {
                _painter.Clear();
                _painter.UpdateTmpBitmap();
                _painter.UpdatePictureBox();
                foreach (IFigure a in figures)
                {
                    if (curentFigure != a)
                    {
                        a.Draw();
                    }
                }
                _painter.SetMainBitmap();
            }
        }

        public void MouseMove(MouseEventArgs e, IFigure curentFigure)
        {
            _painter.UpdateTmpBitmap();
            _painter.UpdatePictureBox();
            curentFigure.Move(e.X - curentFigure.StartPoint.X, e.Y - curentFigure.StartPoint.Y);
            curentFigure.Draw();
            GC.Collect();
        }

        public void MouseUp(MouseEventArgs e, ref IFigure curentFigure, List<IFigure> figures)
        {
            _painter.SetMainBitmap();
            curentFigure = null;
        }
    }
}
