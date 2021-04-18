using System;
using System.Windows.Forms;
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
            _painter.UpdateTmpBitmap();
            _painter.UpdatePictureBox();
            _currentFigure.Draw();
            _painter.SetMainBitmap();
            this.Close();
        }
    }
}
