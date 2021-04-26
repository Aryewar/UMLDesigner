using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using UMLDesigner.Figures;
using UMLDesigner.Figures.Factories;
using UMLDesigner.Figures.Rectangles;
using UMLDesigner.Figures.SinglePainter;
using UMLDesigner.MouseHandler;

namespace UMLDesigner
{
    public partial class UMLDesigner : Form
    {
       
        private Painter _painter;
        private ClassDialogForm _classDialogForm;
        public UMLDesigner()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            colorButton.BackColor = colorDialog.Color;
            _painter = Painter.GetPainter();
            _painter.SetPictureBox(pictureBox);
            _classDialogForm = new ClassDialogForm();
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
        private void widthBar_Scroll(object sender, EventArgs e)
        {
            _painter.PainterPen.Width = widthBar.Value;
        }
        private void CustomMouseDown(object sender, MouseEventArgs e)
        {
            _painter.MouseHandler.MouseDown(sender, e);
        }
        private void CustomMouseMove(object sender, MouseEventArgs e)
        {
            if (_painter.CurentFigure != null)
            {
                _painter.MouseHandler.MouseMove(sender, e);
            }
        }
        private void CustomMouseUp(object sender, MouseEventArgs e)
        {
            _painter.MouseHandler.MouseUp(sender, e);
        }
        private void CustomMouseDoubleClick(object sender, MouseEventArgs e)
        {
            _painter.MouseHandler.MouseDoubleClick(sender, e, _classDialogForm);
        }
        private void radioButtonInheritanceArrow_CheckedChanged(object sender, EventArgs e)
        {
            _painter.Factory = new InharitanceArrowFactory();
            _painter.MouseHandler = new DrawArrowMouseHandler();
            _painter.SetRectanleShowPorts(true);
        }
        private void radioButtonRealizationArrow_CheckedChanged(object sender, EventArgs e)
        {
            _painter.Factory = new RealizationArrowFactory();
            _painter.MouseHandler = new DrawArrowMouseHandler();
            _painter.SetRectanleShowPorts(true);
        }
        private void radioButtonAssociationArrow_CheckedChanged(object sender, EventArgs e)
        {
            _painter.Factory = new AssociationArrowFactory();
            _painter.MouseHandler = new DrawArrowMouseHandler();
            _painter.SetRectanleShowPorts(true);
        }
        private void radioButtonCompositionArrow_CheckedChanged(object sender, EventArgs e)
        {
            _painter.Factory = new CompositionArrowFactory();
            _painter.MouseHandler = new DrawArrowMouseHandler();
            _painter.SetRectanleShowPorts(true);
        }
        private void radioButtonAlternateCompositionArrow_CheckedChanged(object sender, EventArgs e)
        {
            _painter.Factory = new AlternateCompositionArrowFactory();
            _painter.MouseHandler = new DrawArrowMouseHandler();
            _painter.SetRectanleShowPorts(true);
        }
        private void radioButtonAgregationArrow_CheckedChanged(object sender, EventArgs e)
        {
            _painter.Factory = new AgregationArrowFactory();
            _painter.MouseHandler = new DrawArrowMouseHandler();
            _painter.SetRectanleShowPorts(true);
        }
        private void radioButtonAlternateAgregationArrow_CheckedChanged(object sender, EventArgs e)
        {
            _painter.Factory = new AlternateAgragationArrowFactory();
            _painter.MouseHandler = new DrawArrowMouseHandler();
            _painter.SetRectanleShowPorts(true);
        }
        private void radioButtonClass_CheckedChanged(object sender, EventArgs e)
        {
            _painter.Factory = new ClassRectangleFactory();
            _painter.MouseHandler = new DrawRectangleMouseHandler();
            _painter.SetRectanleShowPorts(false);
        }
        private void radioButtonStack_CheckedChanged(object sender, EventArgs e)
        {
            _painter.Factory = new StackRectangleFactory();
            _painter.MouseHandler = new DrawRectangleMouseHandler();
            _painter.SetRectanleShowPorts(false);
        }
        private void radioButtonCursor_CheckedChanged(object sender, EventArgs e)
        {
            _painter.Factory = null;
            _painter.MouseHandler = new CursorMouseHandler();
            _painter.SetRectanleShowPorts(false);
        }
        private void buttonClear_Click(object sender, EventArgs e)
        {
            _painter.Figures = new List<IFigure>();
            _painter.Clear();
        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            
        }
        private void buttonOpenDiram_Click(object sender, EventArgs e)
        {
            
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
        }
        private void trackBarScale_Scroll(object sender, EventArgs e)
        {
            textBoxScale.Text = (trackBarScale.Value).ToString();
            _painter.Scale = (float)trackBarScale.Value/100;
            _painter.Clear();
            foreach (IFigure a in _painter.Figures)
            {
                if (a.figureType == Painter.FigureType.ClassRectangle)
                {
                    ClassRectangle cur = (ClassRectangle)a;
                    cur.textFont = new Font(cur.textFont.FontFamily, cur.FontSize * _painter.Scale, cur.textFont.Style);
                }
                a.Draw();
            }
            _painter.SetMainBitmap();
            _painter.UpdatePictureBox();
        }
        private void textBoxScale_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                trackBarScale_Scroll(sender, e);
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openDiagramDialog.ShowDialog() == DialogResult.OK)
            {
                string fileContent = string.Empty;
                string path = openDiagramDialog.FileName;

                using (StreamReader sr = new StreamReader(path))
                {
                    fileContent = sr.ReadToEnd();
                }
                _painter.DeserializeDiagram(fileContent);
            }
        }

        private void saveToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (saveDiagramDialog.ShowDialog() == DialogResult.OK)
            {
                string path = saveDiagramDialog.FileName;
                string fileText = _painter.SerializeDiagram();
                using (StreamWriter sw = new StreamWriter(path, false))
                {
                    sw.Write(fileText);
                }
            }
        }

        private void exportToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string path = saveFileDialog.FileName;
                _painter.ExportImage(path);
            }
        }

        
    }
}
