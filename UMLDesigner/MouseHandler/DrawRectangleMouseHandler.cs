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
    class DrawRectangleMouseHandler : IMouseHandler
    {
        private Painter _painter = Painter.GetPainter();
        public void MouseDown(MouseEventArgs e, ref IFigure curentFigure, IFigureFabric fabric, List<IFigure> figures)
        {
            curentFigure = fabric.GetFigure();
        }

        public void MouseMove(MouseEventArgs e, IFigure curentFigure)
        {

        }

        public void MouseUp(MouseEventArgs e, ref IFigure curentFigure, List<IFigure> figures)
        {
            curentFigure.StartPoint = e.Location;
            _painter.UpdateTmpBitmap();
            _painter.UpdatePictureBox();
            curentFigure.Draw();
            _painter.SetMainBitmap();
            figures.Add(curentFigure);
            curentFigure = null;
        }
    }
}
