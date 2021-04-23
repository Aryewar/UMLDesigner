using System;
using System.Drawing;
using System.Windows.Forms;
using UMLDesigner.Figures;
using UMLDesigner.Figures.Rectangles;
using UMLDesigner.Figures.SinglePainter;

namespace UMLDesigner
{
    public partial class ClassDialogForm : Form
    {
        private ClassRectangle _currentFigure;
        private Painter _painter;
        public ClassDialogForm()
        {
            InitializeComponent();
        }

        public void OpenCurrentFigure(ClassRectangle classRectangle)
        {
            _currentFigure = classRectangle;
            textBoxTitle.Text = _currentFigure.Title.ToString();
            textBoxFields.Text = _currentFigure.Fields.ToString();
            textBoxProperties.Text = _currentFigure.Properties.ToString();
            textBoxMethods.Text = _currentFigure.Methods.ToString();
            colorDialogBackground.Color = _currentFigure.FigureBrush.Color;
            buttonBackColor.BackColor = _currentFigure.FigureBrush.Color;
            colorDialogText.Color = _currentFigure.FigurePen.Color;
            buttonTextColor.BackColor = _currentFigure.FigurePen.Color;
            trackBar1.Value = (int) _currentFigure.FigurePen.Width;
            
            _painter = Painter.GetPainter();
            this.ShowDialog();
        }
        private void textBoxTitle_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBoxProperties_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxFields_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxMethods_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            _currentFigure.Title.Clear();
            _currentFigure.Fields.Clear();
            _currentFigure.Properties.Clear();
            _currentFigure.Methods.Clear();

            if(!textBoxTitle.Text.Equals(string.Empty))
            {
                _currentFigure.Title.Append(textBoxTitle.Text);
            }
            else
            {
                _currentFigure.Title.Append("Title");
            }

            _currentFigure.Fields.Append(textBoxFields.Text);
            _currentFigure.Properties.Append(textBoxProperties.Text);
            _currentFigure.Methods.Append(textBoxMethods.Text);
            _painter.UpdatePictureBox();
            _currentFigure.Draw();
            foreach(IFigure a in _currentFigure.Links)
            {
                a.Draw();
            }
            _painter.SetMainBitmap();
            this.Close();
        }

        private void buttonTextColor_Click(object sender, EventArgs e)
        {
            colorDialogText.ShowDialog();
            buttonTextColor.BackColor = colorDialogText.Color;
            _currentFigure.PenColor = colorDialogText.Color;
            _currentFigure.FigurePen.Color = _currentFigure.PenColor;
        }

        private void buttonBackColor_Click(object sender, EventArgs e)
        {
            colorDialogBackground.ShowDialog();
            buttonBackColor.BackColor = colorDialogBackground.Color;
            _currentFigure.FigureBackColor = colorDialogBackground.Color;
            _currentFigure.FigureBrush = new SolidBrush(_currentFigure.FigureBackColor);
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            _currentFigure.PenWidth = trackBar1.Value;
            _currentFigure.FigurePen.Width = _currentFigure.PenWidth;
        }
    }
}
