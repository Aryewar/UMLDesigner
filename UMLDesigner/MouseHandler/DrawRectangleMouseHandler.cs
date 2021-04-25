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
        public void MouseDown(object sender, MouseEventArgs e)
        {
            _painter.CurentFigure = _painter.Fabric.GetFigure();
        }

        public void MouseMove(object sender, MouseEventArgs e)
        {

        }

        public void MouseUp(object sender, MouseEventArgs e)
        {
            _painter.CurentFigure.StartPoint = e.Location;
            _painter.UpdatePictureBox();
            _painter.CurentFigure.Draw();
            _painter.SetMainBitmap();
            _painter.Figures.Add(_painter.CurentFigure);
            _painter.CurentFigure = null;
        }
        public void MouseDoubleClick(object sender, MouseEventArgs e, ClassDialogForm _classDialogForm)
        {

        }
    }
}
