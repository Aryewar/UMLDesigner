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
        private AbstractRectangle _crntRectangle;
        private bool _isClicked = false;
        private bool _isRectangle = false;
        private bool _isMove = false;
        List<AbstractRectangle> rectangles;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            rectangles = new List<AbstractRectangle>();

            colorButton.BackColor = colorDialog.Color;
            _pen = new Pen(colorDialog.Color, widthBar.Value);
            _mainBitmap = new Bitmap(pictureBox.Width, pictureBox.Height);
            _graphics = Graphics.FromImage(_mainBitmap);
            
            

            pictureBox.Image = _mainBitmap;
        }

        private void pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            _isClicked = true;
            _start = e.Location;
            if (_isMove)
            {
                foreach (AbstractRectangle a in rectangles)
                {
                    if (a.IsSelected(e.Location))
                    {
                        _crntRectangle = a;
                        break;
                    }
                }
                if (_crntRectangle != null)
                {
                    rectangles.Remove(_crntRectangle);
                    _mainBitmap = new Bitmap(pictureBox.Width, pictureBox.Height);
                    _graphics = Graphics.FromImage(_mainBitmap);
                    //_graphics.Clear(Color.White);

                    foreach (AbstractRectangle a in rectangles)
                    {
                        a.DrawRectangle(_graphics);
                    }
                    pictureBox.Image = _mainBitmap;
                    _start = e.Location;
                }

            }
            else
            {


                _tmpBitmap = (Bitmap)_mainBitmap.Clone();
                _graphics = Graphics.FromImage(_tmpBitmap);
                if (_isRectangle)
                {
                    _crntRectangle = new RectangleFull(_pen, _start);
                    _crntRectangle.RectanglePen.Color = colorDialog.Color;
                    _crntRectangle.RectanglePen.Width = widthBar.Value;

                    _crntRectangle.DrawRectangle(_graphics);
                    rectangles.Add(_crntRectangle);
                }
                pictureBox.Image = _tmpBitmap;
            }
           
        }

        private void pictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            _isClicked = false;
            _finish = e.Location;
            _mainBitmap = _tmpBitmap;
            if (_isRectangle)
            {
                _isRectangle = false;
                button1.BackColor = Color.White;
            }
            
        }

        private void pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (_isClicked)
            {
                if (_isMove && _crntRectangle!=null)
                {
                    _crntRectangle.Move(e.X - _start.X, e.Y - _start.Y);
                    _start = e.Location;
                }
                
                _tmpBitmap = (Bitmap)_mainBitmap.Clone();
                _graphics = Graphics.FromImage(_tmpBitmap);
                _crntRectangle.DrawRectangle(_graphics);

                pictureBox.Image = _tmpBitmap;
                GC.Collect();
            }
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
            _arrow.ArrowPen.Color = colorDialog.Color;
            _arrow.ArrowPen.Width = widthBar.Value;
        }

        private void inheritanceArrow_CheckedChanged(object sender, EventArgs e)
        {
            _arrow = new InheritArrows(_pen, _start, _finish);
            _arrow.ArrowPen.Color = colorDialog.Color;
            _arrow.ArrowPen.Width = widthBar.Value;
        }

        private void associationArrow_CheckedChanged(object sender, EventArgs e)
        {
            _arrow = new AssociationArrows(_pen, _start, _finish);
            _arrow.ArrowPen.Color = colorDialog.Color;
            _arrow.ArrowPen.Width = widthBar.Value;
        }

        private void compositionArrow_CheckedChanged(object sender, EventArgs e)
        {
            _arrow = new CompositionArrows(_pen, _start, _finish);
            _arrow.ArrowPen.Color = colorDialog.Color;
            _arrow.ArrowPen.Width = widthBar.Value;
        }

        private void agragationArrow_CheckedChanged(object sender, EventArgs e)
        {
            _arrow = new AgragationArrows(_pen, _start, _finish);
            _arrow.ArrowPen.Color = colorDialog.Color;
            _arrow.ArrowPen.Width = widthBar.Value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            _isRectangle = true;
            button1.BackColor = Color.Green;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            _crntRectangle = null;
            _isMove = true;
        }
    }
}
