using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using UMLDesigner.Figures;
using UMLDesigner.Figures.Fabrics;
using UMLDesigner.Figures.SinglePainter;
using UMLDesigner.MouseHandler;

namespace UMLDesigner
{
    public partial class Form1 : Form
    {
        private bool _isMoved = false;

        private IFigure _curentFigure;
        private List<IFigure> _figures;
        private IFigureFabric _fabric;
        private IMouseHandler _mouseHandler;
        private Painter _painter;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            colorButton.BackColor = colorDialog.Color;
            _painter = Painter.GetPainter();
            _painter.SetPictureBox(pictureBox);
            _figures = new List<IFigure>();
        }

        private void colorButton_Click(object sender, EventArgs e)
        {
            colorDialog.ShowDialog();
            colorButton.BackColor = colorDialog.Color;
            _painter.PainterPen.Color = colorDialog.Color;

        }

        private void widthBar_Scroll(object sender, EventArgs e)
        {
            _painter.PainterPen.Width = widthBar.Value;
        }

        private void moveButton_Click(object sender, EventArgs e)
        {
            if (_isMoved)
            {
                _isMoved = false;
                moveButton.BackColor = Color.White;
            }
            else
            {
                _isMoved = true;
                moveButton.BackColor = Color.Gray;
            }
        }

        private void CustomMouseDown(object sender, MouseEventArgs e)
        {
            _mouseHandler.MouseDown(e,ref _curentFigure, _fabric);
        }

        private void CustomMouseMove(object sender, MouseEventArgs e)
        {
            if (_curentFigure != null)
            {
                _mouseHandler.MouseMove(e, _curentFigure);
            }
        }

        private void CustomMouseUp(object sender, MouseEventArgs e)
        {
            _mouseHandler.MouseUp(e, ref _curentFigure, _figures);
        }

        private void buttonRealizationArrow_Click(object sender, EventArgs e)
        {
            _fabric = new RealizationArrowFabric();
            _mouseHandler = new DrawArrowMouseHandler();
        }

        private void buttonAssociationArrow_Click(object sender, EventArgs e)
        {
            _fabric = new AssociationArrowFabric();
            _mouseHandler = new DrawArrowMouseHandler();
        }

        private void buttonCompozitionArrow_Click(object sender, EventArgs e)
        {
            _fabric = new CompositionArrowFabric();
            _mouseHandler = new DrawArrowMouseHandler();
        }

        private void buttonAlternateCompositionArrow_Click(object sender, EventArgs e)
        {
            _fabric = new AlternateCompositionArrowFabric();
            _mouseHandler = new DrawArrowMouseHandler();
        }

        private void buttonAgregationArrow_Click(object sender, EventArgs e)
        {
            _fabric = new AgregationArrowFabric();
            _mouseHandler = new DrawArrowMouseHandler();
        }

        private void buttonAlternateAgregationArrow_Click(object sender, EventArgs e)
        {
            _fabric = new AlternateAgragationArrowFabric();
            _mouseHandler = new DrawArrowMouseHandler();
        }

        private void buttonInheritanceArrow_Click(object sender, EventArgs e)
        {
            _fabric = new InharitanceArrowFabric();
            _mouseHandler = new DrawArrowMouseHandler();
        }

        private void ButtonClassRectangle_Click(object sender, EventArgs e)
        {
            _fabric = new ClassRectangleFabric();
            _mouseHandler = new DrawRectangleMouseHandler();
        }
    }
}
