using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UMLDesigner.Figures;
using UMLDesigner.Figures.Fabrics;
using UMLDesigner.Figures.SinglePainter;

namespace UMLDesigner.MouseHandler
{
    public class RemoveMouseHndler : IMouseHandler
    {
        private Painter _painter = Painter.GetPainter();
        
        public void MouseDoubleClick(MouseEventArgs e, ClassDialogForm _classDialogForm)
        {
            
        }

        public void MouseDown(MouseEventArgs e)
        {
            
            foreach (IFigure a in _painter.Figures)
            {
                if (a.IsSelected(e.Location))
                {
                    _painter.Figures.Remove(a);
                    _painter.RemovedFigures.Add(a);
                    _painter.Clear();
                    _painter.UpdatePictureBox();
                    foreach (IFigure b in _painter.Figures)
                    {
                            b.Draw();
                    }
                    _painter.SetMainBitmap();
                    break;
                }
            }
        }

        public void MouseMove(MouseEventArgs e)
        {
            
        }

        public void MouseUp(MouseEventArgs e)
        {
            
        }
    }
}
