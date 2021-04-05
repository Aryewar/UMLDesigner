using System;
using System.Collections.Generic;
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

        List<Arrow> arrows = new List<Arrow> { };
        bool isClicked = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            isClicked = true;
            _start = e.Location;

            if (inheritanceArrow.Checked)
            {
                _arrow = new InheritArrows(_pen, _start, _finish);
            }
            if (realizationArrow.Checked)
            {
                _arrow = new RealizationArrows(_pen, _start, _finish);
            }
            if (associationArrow.Checked)
            {
                _arrow = new AssociationArrows(_pen, _start, _finish);
            }
        }

        private void pictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            isClicked = false;
            _finish = e.Location;
            _mainBitmap = _tmpBitmap;

            if (inheritanceArrow.Checked)
            {
                arrows.Add(new InheritArrows(_pen, _start, _finish));
            }
            if (realizationArrow.Checked)
            {
                arrows.Add(new RealizationArrows(_pen, _start, _finish));
            }
            if (associationArrow.Checked)
            {
                arrows.Add(new AssociationArrows(_pen, _start, _finish));
            }
        }

        private void pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (isClicked)
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
    }
}
