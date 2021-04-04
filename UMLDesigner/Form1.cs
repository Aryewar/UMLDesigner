using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UMLDesigner
{
    public partial class Form1 : Form
    {
        Point start;
        Point finish;

        List<Arrow> arrows = new List<Arrow> { };

        bool isClicked = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            isClicked = true;
            start.X = e.X;
            start.Y = e.Y;
        }

        private void pictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            isClicked = false;
            if (inheritanceArrow.Checked)
            {
                arrows.Add(new InheritArrows(start, finish));
            }
            if (realizationArrow.Checked)
            {
                arrows.Add(new RealizationArrows(start, finish));
            }
            if (associationArrow.Checked)
            {
                arrows.Add(new AssociationArrows(start, finish));
            }
        }

        private void pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (isClicked)
            {
                finish.X = e.X;
                finish.Y = e.Y;
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
    }
}
