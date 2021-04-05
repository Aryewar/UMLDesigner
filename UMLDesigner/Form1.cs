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
        }

        private void pictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            isClicked = false;
            if (inheritanceArrow.Checked)
            {
                arrows.Add(new InheritArrows(new Pen(colorDialog.Color, widthBar.Value), _start, _finish));
            }
            if (realizationArrow.Checked)
            {
                arrows.Add(new RealizationArrows(new Pen(colorDialog.Color, widthBar.Value), _start, _finish));
            }
            if (associationArrow.Checked)
            {
                arrows.Add(new AssociationArrows(new Pen(colorDialog.Color, widthBar.Value), _start, _finish));
            }
        }

        private void pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (isClicked)
            {
                _finish.X = e.X;
                _finish.Y = e.Y;
                pictureBox.Invalidate();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _pen = new Pen(colorDialog.Color, widthBar.Value);
            _mainBitmap = new Bitmap(pictureBox.Width, pictureBox.Height);
            _graphics = Graphics.FromImage(_mainBitmap);

            pictureBox.Image = _mainBitmap;
        }

        private void pictureBox_Paint(object sender, PaintEventArgs e)
        {
            foreach (var p in arrows)
            {
                e.Graphics.DrawLine(p.Pen, p.Start, p.Finish);
            }
            pictureBox.Invalidate();
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
