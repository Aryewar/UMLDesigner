using System.Drawing;
using System.Windows.Forms;

namespace UMLDesigner.Figures.SinglePainter
{
    public class Painter
    {
        public Graphics PainterGraphics { get; set; }
        public Pen PainterPen { get; set; }
        public Brush PainterBrush { get; set; }

        private Bitmap _tmpBitmap;
        private Bitmap _mainBitmap;
        private PictureBox _pictureBox;
        private static Painter _painter;

        private Painter()
        {
            PainterPen = new Pen(Color.Black, 3);
            PainterBrush = new SolidBrush(Color.White);
        }

        public void SetPictureBox(PictureBox pictureBox)
        {
            _pictureBox = pictureBox;
            _mainBitmap = new Bitmap(_pictureBox.Width, _pictureBox.Height);
            _tmpBitmap = (Bitmap)_mainBitmap.Clone();
            PainterGraphics = Graphics.FromImage(_tmpBitmap);
            _pictureBox.BackColor = Color.White;
            _pictureBox.Image = _tmpBitmap;
        }

        public static Painter GetPainter()
        {
            if (_painter is null)
            {
                _painter = new Painter();
            }

            return _painter;
        }

        public void UpdateTmpBitmap()
        {
           _tmpBitmap = (Bitmap)_mainBitmap.Clone();
        }

        public void SetMainBitmap()
        {
            _mainBitmap = _tmpBitmap;
        }

        public void UpdatePictureBox()
        {
            _pictureBox.Image = _tmpBitmap;
            PainterGraphics = Graphics.FromImage(_tmpBitmap);
        }

        public void Clear()
        {
            _mainBitmap = new Bitmap(_pictureBox.Width, _pictureBox.Height);
        }
    }
}
