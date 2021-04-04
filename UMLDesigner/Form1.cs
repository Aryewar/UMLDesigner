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
        Bitmap _bitmap;
        Graphics _graphics;
        Pen _pen;
        Point start;
        Point finish;

        List<twoPoint> inheritLines = new List<twoPoint> { };
        List<twoPoint> realizationLines = new List<twoPoint> { };
        List<twoPoint> associationLines = new List<twoPoint> { };
        List<twoPoint> compositionLines = new List<twoPoint> { };
        List<twoPoint> agrigationLines = new List<twoPoint> { };

        bool isClicked = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {

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
                inheritLines.Add(new twoPoint(start, finish));
            }
            if (realizationArrow.Checked)
            {
                realizationLines.Add(new twoPoint(start, finish));
            }
            if (associationArrow.Checked)
            {
                associationLines.Add(new twoPoint(start, finish));
            }
            if (compositionArrow.Checked)
            {
                compositionLines.Add(new twoPoint(start, finish));
            }
            if (agragationArrow.Checked)
            {
                agrigationLines.Add(new twoPoint(start, finish));
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
            _pen = new Pen(Color.Green, 5);
            if (inheritanceArrow.Checked)
            {
                _pen.CustomEndCap = new AdjustableArrowCap(10, 10);
            }
            if (realizationArrow.Checked)
            {
                _pen.DashStyle = DashStyle.Dash;
                _pen.CustomEndCap = new AdjustableArrowCap(10, 10);
            }
            if (associationArrow.Checked)
            {
                _pen.CustomEndCap = new AdjustableArrowCap(10, 10, false);
            }
            if (compositionArrow.Checked)
            {
                _pen.StartCap = LineCap.DiamondAnchor;
                _pen.EndCap = LineCap.ArrowAnchor;
            }
            if (agragationArrow.Checked)
            {
                _pen.EndCap = LineCap.ArrowAnchor;
            }

            e.Graphics.DrawLine(_pen, start, finish);

            foreach (var p in inheritLines)
            {
                _pen.CustomEndCap = new AdjustableArrowCap(10, 10);
                e.Graphics.DrawLine(_pen, p.Start, p.Finish);
            }
            foreach (var p in realizationLines)
            {
                _pen.DashStyle = DashStyle.Dash;
                _pen.CustomEndCap = new AdjustableArrowCap(10, 10);
                e.Graphics.DrawLine(_pen, p.Start, p.Finish);
            }
            foreach (var p in associationLines)
            {
                _pen.CustomEndCap = new AdjustableArrowCap(10, 10, false);
                e.Graphics.DrawLine(_pen, p.Start, p.Finish);
            }
            foreach (var p in compositionLines)
            {
                _pen.StartCap = LineCap.DiamondAnchor;
                _pen.EndCap = LineCap.ArrowAnchor;
                e.Graphics.DrawLine(_pen, p.Start, p.Finish);
            }
            foreach (var p in agrigationLines)
            {
                _pen.EndCap = LineCap.ArrowAnchor;
                e.Graphics.DrawLine(_pen, p.Start, p.Finish);
            }
        }
    }
}
