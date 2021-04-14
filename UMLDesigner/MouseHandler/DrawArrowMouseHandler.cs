using System;
using System.Collections.Generic;
using System.Windows.Forms;
using UMLDesigner.Figures;
using UMLDesigner.Figures.Fabrics;
using UMLDesigner.Figures.SinglePainter;

namespace UMLDesigner.MouseHandler
{
    public class DrawArrowMouseHandler : IMouseHandler
    {
        private Painter _painter = Painter.GetPainter();
        public void MouseDown(MouseEventArgs e,ref IFigure curentFigure, IFigureFabric fabric)
        {
            curentFigure = fabric.GetFigure();
            curentFigure.StartPoint = e.Location;
        }

        public void MouseMove(MouseEventArgs e, IFigure curentFigure)
        {
            _painter.UpdateTmpBitmap();
            curentFigure.FinishPoint = e.Location;
            _painter.UpdatePictureBox();
            curentFigure.Draw();
            GC.Collect();
        }

        public void MouseUp(MouseEventArgs e, ref IFigure curentFigure, List<IFigure> figures)
        {
            _painter.SetMainBitmap();
            figures.Add(curentFigure);
            curentFigure = null;
        }
    }
}
