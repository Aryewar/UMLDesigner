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
        private AbstractArrow _curentArrow;
        private bool _isClicked = false;
        private bool _isMoved = false;
        private List<AbstractArrow> _arrows;
        private AbstractArrow.Arrows _arrowType;

        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            _start = e.Location;

            if (_isMoved)
            {
                foreach (AbstractArrow a in _arrows)
                {
                    a.IsItEndArrow(e.Location);
                    a.IsItStartArrow(e.Location);

                    if(a.StrartArrow || a.EndArrow)
                    {
                        _curentArrow = a;
                    }
                }

                if (_curentArrow != null )
                {
                    _arrows.Remove(_curentArrow);

                    _mainBitmap = new Bitmap(pictureBox.Width, pictureBox.Height);
                    _graphics = Graphics.FromImage(_mainBitmap);

                    foreach (AbstractArrow a in _arrows)
                    {
                        a.DrawArrow(_graphics, a.StartPoint, a.FinishPoint);
                    }

                    pictureBox.Image = _mainBitmap;
                }
            }
            else
            {
                switch (_arrowType)
                {
                    case AbstractArrow.Arrows.AgragationArrows:
                        _curentArrow = new AgragationArrows(_pen, _start, _finish);
                        break;
                    case AbstractArrow.Arrows.AssociationArrows:
                        _curentArrow = new AssociationArrows(_pen, _start, _finish);
                        break;
                    case AbstractArrow.Arrows.CompositionArrows:
                        _curentArrow = new CompositionArrows(_pen, _start, _finish);
                        break;
                    case AbstractArrow.Arrows.InheritArrows:
                        _curentArrow = new InheritArrows(_pen, _start, _finish);
                        break;
                    case AbstractArrow.Arrows.RealizationArrows:
                        _curentArrow = new RealizationArrows(_pen, _start, _finish);
                        break;
                }

                _curentArrow.ArrowPen.Color = colorDialog.Color;
                _curentArrow.ArrowPen.Width = widthBar.Value;
            }
            _isClicked = true;
        }

        private void pictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            _isClicked = false;
            _curentArrow.DrawArrow(_graphics, _curentArrow.StartPoint, _curentArrow.FinishPoint);
            _arrows.Add(_curentArrow);
            _mainBitmap = _tmpBitmap;
        }

        private void pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (_isClicked && !(_curentArrow is null))
            {
                _tmpBitmap = (Bitmap)_mainBitmap.Clone();
                _graphics = Graphics.FromImage(_tmpBitmap);

                if (_isMoved)
                {
                    _curentArrow.MoveArrowCup(_graphics, e.Location);
                }
                else
                {
                    _curentArrow.DrawArrow(_graphics, _start, e.Location);
                }

                pictureBox.Image = _tmpBitmap;
                GC.Collect();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            colorButton.BackColor = colorDialog.Color;
            _arrows = new List<AbstractArrow>();
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
            _arrowType = AbstractArrow.Arrows.RealizationArrows;
        }

        private void inheritanceArrow_CheckedChanged(object sender, EventArgs e)
        {
            _arrowType = AbstractArrow.Arrows.InheritArrows;
        }

        private void associationArrow_CheckedChanged(object sender, EventArgs e)
        {
            _arrowType = AbstractArrow.Arrows.AssociationArrows;
        }

        private void compositionArrow_CheckedChanged(object sender, EventArgs e)
        {
            _arrowType = AbstractArrow.Arrows.CompositionArrows;
        }

        private void agragationArrow_CheckedChanged(object sender, EventArgs e)
        {
            _arrowType = AbstractArrow.Arrows.AgragationArrows;
        }

        private void moveButton_Click(object sender, EventArgs e)
        {
            if(_isMoved)
            {
                _isMoved = false;
                moveButton.BackColor = Color.White;
            }
            else
            {
                _isMoved = true;
                moveButton.BackColor = Color.Gray;
            }
        }
    }
}
