using System.Collections.Generic;
using System.Windows.Forms;
using UMLDesigner.Figures;
using UMLDesigner.Figures.Fabrics;
using UMLDesigner.Figures.SinglePainter;

namespace UMLDesigner.MouseHandler
{
    public interface IMouseHandler
    {
        void MouseUp(MouseEventArgs e, IFigure curentFigure, List<IFigure> figures);
        void MouseDown(MouseEventArgs e, ref IFigure curentFigure, IFigureFabric fabric);
        void MouseMove(MouseEventArgs e, IFigure curentFigure);
    }
}
