using System;
using System.Collections.Generic;
using System.Windows.Forms;
using UMLDesigner.Figures;
using UMLDesigner.Figures.Fabrics;
using UMLDesigner.Figures.SinglePainter;

namespace UMLDesigner.MouseHandler
{
    public class DrawMouseHandler : IMouseHandler
    {
        public void MouseDown(MouseEventArgs e,ref IFigure curentFigure, IFigureFabric fabric)
        {
            curentFigure = fabric.GetFigure();
            curentFigure.StartPoint = e.Location;
        }

        public void MouseMove(MouseEventArgs e, IFigure curentFigure)
        {
            Painter.UpdateTmpBitmap();
            curentFigure.FinishPoint = e.Location;
            curentFigure.Draw();
            Painter.UpdatePictureBox();
        }

        public void MouseUp(MouseEventArgs e, IFigure curentFigure, List<IFigure> figures)
        {
            Painter.SetMainBitmap();
            figures.Add(curentFigure);
        }
    }
}
