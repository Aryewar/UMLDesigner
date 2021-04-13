using System;
using System.Collections.Generic;
using System.Windows.Forms;
using UMLDesigner.Figures;
using UMLDesigner.Figures.Fabrics;

namespace UMLDesigner.MouseHandler
{
    public class CursorMouseHandler : IMouseHandler
    {
        public void MouseDown(MouseEventArgs e,ref IFigure curentFigure, IFigureFabric fabric)
        {
            throw new NotImplementedException();
        }

        public void MouseMove(MouseEventArgs e, IFigure curentFigure)
        {
            throw new NotImplementedException();
        }

        public void MouseUp(MouseEventArgs e, ref IFigure curentFigure, List<IFigure> figures)
        {
            throw new NotImplementedException();
        }
    }
}
