using System;
using System.Drawing;
using System.Windows.Forms;

namespace UMLDesigner
{
    public partial class Form1: Form
    {
        private Point _start;
        private Point _finish;
        private Bitmap _tmpBitmap;
        private Bitmap _mainBitmap;
        private Graphics _graphics;
        private Pen _pen;
        private Arrow _arrow;
        private bool _isClicked = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            _isClicked = true;
            _start = e.Location;
            _arrow.ArrowPen.Color = colorDialog.Color;
            _arrow.ArrowPen.Width = widthBar.Value;
        }

        private void pictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            _isClicked = false;
            _finish = e.Location;
            _mainBitmap = _tmpBitmap;
        }

        private void pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (_isClicked)
            {
                _tmpBitmap = (Bitmap)_mainBitmap.Clone();
                _graphics = Graphics.FromImage(_tmpBitmap);

                _arrow.DrawArrow(_graphics, _start, e.Location);

                pictureBox.Image = _tmpBitmap;
                GC.Collect();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            colorButton.BackColor = colorDialog.Color;
            _pen = new Pen(colorDialog.Color, widthBar.Value);
            _mainBitmap = new Bitmap(pictureBox.Width, pictureBox.Height);
            _graphics = Graphics.FromImage(_mainBitmap);

            pictureBox.Image = _mainBitmap;
        }

        private void colorButton_Click(object sender, EventArgs e)
        {
            colorDialog.ShowDialog();
            colorButton.BackColor = colorDialog.Color;
            _pen.Color = colorDialog.Color;
        }

        private void widthBar_Scroll(object sender, EventArgs e)
        {
            _pen.Width = widthBar.Value;
        }

        private void realizationArrow_CheckedChanged(object sender, EventArgs e)
        {
            _arrow = new RealizationArrows(_pen, _start, _finish);
        }

        private void inheritanceArrow_CheckedChanged(object sender, EventArgs e)
        {
            _arrow = new InheritArrows(_pen, _start, _finish);
        }

        private void associationArrow_CheckedChanged(object sender, EventArgs e)
        {
            _arrow = new AssociationArrows(_pen, _start, _finish);
        }

        private void compositionArrow_CheckedChanged(object sender, EventArgs e)
        {
            _arrow = new CompositionArrows(_pen, _start, _finish);
        }

        private void agragationArrow_CheckedChanged(object sender, EventArgs e)
        {
            _arrow = new AgragationArrows(_pen, _start, _finish);
        }

        private void agregationArrow2_CheckedChanged(object sender, EventArgs e)
        {
            _arrow = new AgragationArrows2(_pen, _start, _finish);
        }

        private void associationArrow2_CheckedChanged(object sender, EventArgs e)
        {
            _arrow = new CompositionArrows2(_pen, _start, _finish);
        }
    }
}
