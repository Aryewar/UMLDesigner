using System.Collections.Generic;
using System.Windows.Forms;
using UMLDesigner.Figures;
using UMLDesigner.Figures.Fabrics;
using UMLDesigner.Figures.SinglePainter;

namespace UMLDesigner.MouseHandler
{
    public interface IMouseHandler
    {
        void MouseDown(MouseEventArgs e, ref IFigure curentFigure, IFigureFabric fabric, List<IFigure> figures);
        void MouseMove(MouseEventArgs e, IFigure curentFigure);
        void MouseUp(MouseEventArgs e, ref IFigure curentFigure, List<IFigure> figures);
    }
}
