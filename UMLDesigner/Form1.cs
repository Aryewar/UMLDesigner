using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using UMLDesigner.Figures;
using UMLDesigner.Figures.Fabrics;
using UMLDesigner.Figures.Rectangles;
using UMLDesigner.Figures.SinglePainter;
using UMLDesigner.MouseHandler;

namespace UMLDesigner
{
    public partial class Form1 : Form
    {
       
        private Painter _painter;
        private ClassDialogForm _classDialogForm;
        private bool isRemoving = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            colorButton.BackColor = colorDialog.Color;
            _painter = Painter.GetPainter();
            _painter.SetPictureBox(pictureBox);
            _classDialogForm = new ClassDialogForm();
            _painter.MouseHandler = new CursorMouseHandler();
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

        private void ButtonUndo_Click(object sender, EventArgs e)
        {

        }

        private void widthBar_Scroll(object sender, EventArgs e)
        {
            _painter.PainterPen.Width = widthBar.Value;
        }

        private void CustomMouseDown(object sender, MouseEventArgs e)
        {
            _painter.MouseHandler.MouseDown(e);
        }

        private void CustomMouseMove(object sender, MouseEventArgs e)
        {
            if (_painter.CurentFigure != null)
            {
                _painter.MouseHandler.MouseMove(e);
            }
        }

        private void CustomMouseUp(object sender, MouseEventArgs e)
        {
            _painter.MouseHandler.MouseUp(e);
        }

        private void CustomMouseDoubleClick(object sender, MouseEventArgs e)
        {

            _painter.MouseHandler.MouseDoubleClick(e, _classDialogForm);


        }

        private void radioButtonInheritanceArrow_CheckedChanged(object sender, EventArgs e)
        {
            _painter.Fabric = new InharitanceArrowFabric();
            _painter.MouseHandler = new DrawArrowMouseHandler();
        }

        private void radioButtonRealizationArrow_CheckedChanged(object sender, EventArgs e)
        {
            _painter.Fabric = new RealizationArrowFabric();
            _painter.MouseHandler = new DrawArrowMouseHandler();
        }

        private void radioButtonAssociationArrow_CheckedChanged(object sender, EventArgs e)
        {
            _painter.Fabric = new AssociationArrowFabric();
            _painter.MouseHandler = new DrawArrowMouseHandler();
        }

        private void radioButtonCompositionArrow_CheckedChanged(object sender, EventArgs e)
        {
            _painter.Fabric = new CompositionArrowFabric();
            _painter.MouseHandler = new DrawArrowMouseHandler();
        }

        private void radioButtonAlternateCompositionArrow_CheckedChanged(object sender, EventArgs e)
        {
            _painter.Fabric = new AlternateCompositionArrowFabric();
            _painter.MouseHandler = new DrawArrowMouseHandler();
        }

        private void radioButtonAgregationArrow_CheckedChanged(object sender, EventArgs e)
        {
            _painter.Fabric = new AgregationArrowFabric();
            _painter.MouseHandler = new DrawArrowMouseHandler();
        }

        private void radioButtonAlternateAgregationArrow_CheckedChanged(object sender, EventArgs e)
        {
            _painter.Fabric = new AlternateAgragationArrowFabric();
            _painter.MouseHandler = new DrawArrowMouseHandler();
        }

        private void radioButtonClass_CheckedChanged(object sender, EventArgs e)
        {
            _painter.Fabric = new ClassRectangleFabric();
            _painter.MouseHandler = new DrawRectangleMouseHandler();
        }

        private void radioButtonCursor_CheckedChanged(object sender, EventArgs e)
        {
            _painter.Fabric = null;
            _painter.MouseHandler = new CursorMouseHandler();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            _painter.Figures = new List<IFigure>();
            _painter.Clear();
        }


        private void RemoveRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            _painter.MouseHandler = new RemoveMouseHndler();
        }

        private void buttonFont_Click(object sender, EventArgs e)
        {
            fontDialogMain.ShowDialog();
            _painter.PainterFont = fontDialogMain.Font;
        }

        private void textBoxScale_TextChanged(object sender, EventArgs e)
        {
            int value = Convert.ToInt32(textBoxScale.Text);
            if (value >= 50 && value <= 150)
            {
                trackBarScale.Value = value;
            } else if (value < 50)
            {
                trackBarScale.Value = 50;
            }
            else
            {
                trackBarScale.Value = 150;
            }
            trackBarScale_Scroll(sender, e);
        }

        private void trackBarScale_Scroll(object sender, EventArgs e)
        {
            textBoxScale.Text = (trackBarScale.Value).ToString();
            _painter.Scale = (float)trackBarScale.Value/100;
            _painter.Clear();
            foreach (IFigure a in _painter.Figures)
            {
                if (a.Type == "ClassRectangle")
                {
                    ClassRectangle cur = (ClassRectangle)a;
                    cur.textFont = new Font(cur.textFont.FontFamily, cur.FontSize * _painter.Scale, cur.textFont.Style);
                    cur.PenWidth *= _painter.Scale;
                }
                a.Draw();
            }

            _painter.SetMainBitmap();

        }
    }
}
