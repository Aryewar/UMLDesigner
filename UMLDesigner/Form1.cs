using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;
using UMLDesigner.Figures;
using UMLDesigner.Figures.Fabrics;
using UMLDesigner.Figures.SinglePainter;
using UMLDesigner.MouseHandler;
using System.Text.Json;

namespace UMLDesigner
{
    public partial class Form1 : Form
    {
        private IFigure _curentFigure;
        private List<IFigure> _figures;
        private IFigureFabric _fabric;
        private IMouseHandler _mouseHandler;
        private Painter _painter;
        private ClassDialogForm _classDialogForm;
        private Converter _convert;
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
            _classDialogForm = new ClassDialogForm();
            _convert = new Converter();
        }

        private void colorButton_Click(object sender, EventArgs e)
        {
            colorDialog.ShowDialog();
            colorButton.BackColor = colorDialog.Color;
            _painter.PainterPen.Color = colorDialog.Color;

        }
        private void buttonBackColor_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            buttonBackColor.BackColor = colorDialog1.Color;
            _painter.PainterBrush = new SolidBrush(colorDialog1.Color);
        }
        private void buttonExport_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            string path = saveFileDialog1.FileName;
            _painter.ExportImage(path);
        }

        private void widthBar_Scroll(object sender, EventArgs e)
        {
            _painter.PainterPen.Width = widthBar.Value;
        }

        private void CustomMouseDown(object sender, MouseEventArgs e)
        {
            _mouseHandler.MouseDown(e,ref _curentFigure, _fabric, _figures);
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

        private void CustomMouseDoubleClick(object sender, MouseEventArgs e)
        {
            _mouseHandler.MouseDoubleClick(e, ref _curentFigure, _figures, _classDialogForm);
        }

        private void radioButtonInheritanceArrow_CheckedChanged(object sender, EventArgs e)
        {
            _fabric = new InharitanceArrowFabric();
            _mouseHandler = new DrawArrowMouseHandler();
        }

        private void radioButtonRealizationArrow_CheckedChanged(object sender, EventArgs e)
        {
            _fabric = new RealizationArrowFabric();
            _mouseHandler = new DrawArrowMouseHandler();
        }

        private void radioButtonAssociationArrow_CheckedChanged(object sender, EventArgs e)
        {
            _fabric = new AssociationArrowFabric();
            _mouseHandler = new DrawArrowMouseHandler();
        }

        private void radioButtonCompositionArrow_CheckedChanged(object sender, EventArgs e)
        {
            _fabric = new CompositionArrowFabric();
            _mouseHandler = new DrawArrowMouseHandler();
        }

        private void radioButtonAlternateCompositionArrow_CheckedChanged(object sender, EventArgs e)
        {
            _fabric = new AlternateCompositionArrowFabric();
            _mouseHandler = new DrawArrowMouseHandler();
        }

        private void radioButtonAgregationArrow_CheckedChanged(object sender, EventArgs e)
        {
            _fabric = new AgregationArrowFabric();
            _mouseHandler = new DrawArrowMouseHandler();
        }

        private void radioButtonAlternateAgregationArrow_CheckedChanged(object sender, EventArgs e)
        {
            _fabric = new AlternateAgragationArrowFabric();
            _mouseHandler = new DrawArrowMouseHandler();
        }

        private void radioButtonClass_CheckedChanged(object sender, EventArgs e)
        {
            _fabric = new ClassRectangleFabric();
            _mouseHandler = new DrawRectangleMouseHandler();
        }

        private void radioButtonCursor_CheckedChanged(object sender, EventArgs e)
        {
            _fabric = null;
            _mouseHandler = new CursorMouseHandler();
        }

        private void buttonSaveProject_Click(object sender, EventArgs e)
        {
            saveProjectDialog.ShowDialog();
            string path = saveProjectDialog.FileName;
            string fileText = _convert.SerializeList(_figures);
            using (StreamWriter sw = new StreamWriter(path, false))
            {
                sw.Write(fileText);
            }
        }

        private void buttonOpenProject_Click(object sender, EventArgs e)
        {
            openProjectDialog.ShowDialog();
            string path = openProjectDialog.FileName; 
        }
    }
}
