using System.Collections.Generic;
using System.Windows.Forms;
using UMLDesigner.Figures;
using UMLDesigner.Figures.Fabrics;
using UMLDesigner.Figures.SinglePainter;

namespace UMLDesigner.MouseHandler
{
    public interface IMouseHandler
    {
        void MouseDown(object sender, MouseEventArgs e);
        void MouseMove(MouseEventArgs e);
        void MouseUp(MouseEventArgs e);
        void MouseDoubleClick(MouseEventArgs e, ClassDialogForm _classDialogForm);
    }
}
