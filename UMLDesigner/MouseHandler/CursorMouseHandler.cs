using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using UMLDesigner.Figures;
using UMLDesigner.Figures.Factories;
using UMLDesigner.Figures.Rectangles;
using UMLDesigner.Figures.SinglePainter;

namespace UMLDesigner.MouseHandler
{
    public class CursorMouseHandler : IMouseHandler
    {
        private Painter _painter = Painter.GetPainter();
        public void MouseDown(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Left:
                    foreach (IFigure a in _painter.Figures)
                    {
                        if (a.IsSelected(e.Location))
                        {
                            _painter.CurentFigure = a;
                            break;
                        }
                    }
                    if (_painter.CurentFigure != null)
                    {
                        _painter.CurentFigure.PrevPosition = e.Location;
                        _painter.Clear();
                        foreach (IFigure a in _painter.Figures)
                        {
                            if (_painter.CurentFigure != a && !_painter.CurentFigure.Links.Contains(a))
                            {
                                a.Draw();
                            }
                        }

                        _painter.SetMainBitmap();
                        MouseMove(sender, e);
                    }
                    break;

                case MouseButtons.Right:
                    foreach (IFigure a in _painter.Figures)
                    {
                        if (a.IsSelected(e.Location))
                        {
                            var control = sender as Control;
                            RightClickDialog propertiesWindow = new RightClickDialog();
                            propertiesWindow.OpenPropertiesDialog(a, control.PointToScreen(e.Location));
                            break;
                        }
                    }
                    break;
            }
        }

        public void MouseMove(object sender, MouseEventArgs e)
        {
            _painter.UpdatePictureBox();
            _painter.CurentFigure.Move(e.Location);
            _painter.CurentFigure.Draw();
            GC.Collect();
        }

        public void MouseUp(object sender, MouseEventArgs e)
        {
            _painter.SetMainBitmap();
            _painter.CurentFigure = null;
        }
        public void MouseDoubleClick(object sender, MouseEventArgs e, ClassDialogForm _classDialogForm)
        {
            foreach (IFigure a in _painter.Figures)
            {
                if (a.IsSelected(e.Location))
                {
                    _painter.CurentFigure = a;
                    break;
                }
            }
            if (_painter.CurentFigure is ClassRectangle)
            {
                var control = sender as Control;
                Point startPosition = new Point(e.X - 240, e.Y - 250);
                _classDialogForm.Location = control.PointToScreen(startPosition);
                _classDialogForm.OpenCurrentFigure((ClassRectangle)_painter.CurentFigure);
            }
        }
    }
}
