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


        List<Arrow> arrows = new List<Arrow> { };
        bool isClicked = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            isClicked = true;
            _start.X = e.X;
            _start.Y = e.Y;
        }

        private void pictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            isClicked = false;
            if (inheritanceArrow.Checked)
            {
                arrows.Add(new InheritArrows(_start, _finish));
            }
            if (realizationArrow.Checked)
            {
                arrows.Add(new RealizationArrows(_start, _finish));
            }
            if (associationArrow.Checked)
            {
                arrows.Add(new AssociationArrows(_start, _finish));
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

        }

        private void pictureBox_Paint(object sender, PaintEventArgs e)
        {
            foreach (var p in arrows)
            {
                e.Graphics.DrawLine(p.Pen, p.Start, p.Finish);
            }
            pictureBox.Invalidate();
        }

        private void button1_DragDrop(object sender, DragEventArgs e)
        {
            e.Graphics.
        }
    }
}
