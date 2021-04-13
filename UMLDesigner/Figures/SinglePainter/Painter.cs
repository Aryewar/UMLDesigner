using System.Drawing;
using System.Windows.Forms;

namespace UMLDesigner.Figures.SinglePainter
{
    public class Painter
    {
        public static Graphics PainterGraphics { get; set; }
        public static Pen PainterPen { get; set; }

        private static Bitmap _tmpBitmap;
        private static Bitmap _mainBitmap;
        private static PictureBox _pictureBox;
        private static Painter _painter;

        private Painter(PictureBox pictureBox)
        {
            _pictureBox = pictureBox;
            PainterPen = new Pen(Color.Black, 3);
            _mainBitmap = new Bitmap(pictureBox.Width, pictureBox.Height);
            _tmpBitmap = (Bitmap)_mainBitmap.Clone();
            PainterGraphics = Graphics.FromImage(_tmpBitmap);
            _pictureBox.BackColor = Color.White;
            _pictureBox.Image = _tmpBitmap;
        }

        public static Painter GetPainter(PictureBox pictureBox)
        {
            if (_painter is null)
            {
                return new Painter(pictureBox);
            }

            return _painter;
        }

        public static void UpdateTmpBitmap()
        {
           _tmpBitmap = (Bitmap)_mainBitmap.Clone();
        }

        public static void SetMainBitmap()
        {
            _mainBitmap = _tmpBitmap;
        }

        public static void UpdatePictureBox()
        {
            _pictureBox.Image = _tmpBitmap;
            PainterGraphics = Graphics.FromImage(_tmpBitmap);
        }
    }
}
