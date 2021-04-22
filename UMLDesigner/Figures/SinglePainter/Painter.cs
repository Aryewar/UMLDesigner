using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;
using UMLDesigner.Figures.Fabrics;
using UMLDesigner.Figures.Rectangles;
using UMLDesigner.MouseHandler;

namespace UMLDesigner.Figures.SinglePainter
{
    public class Painter
    {
        public Graphics PainterGraphics { get; set; }
        public Pen PainterPen { get; set; }
        public SolidBrush PainterBrush { get; set; }
        public IFigure CurentFigure { get; set; }
        public List<IFigure> Figures { get; set; }
        public List<IFigure> RemovedFigures { get; set; }
        public IFigureFabric Fabric { get; set; }
        public IMouseHandler MouseHandler { get; set; }
        public float Scale { get; set; }
        public Font PainterFont { get; set; }
        

        private Bitmap _tmpBitmap;
        private Bitmap _mainBitmap;
        private PictureBox _pictureBox;
        private static Painter _painter;

        private Painter()
        {
            PainterPen = new Pen(Color.Black, 1);
            PainterBrush = new SolidBrush(Color.White);
            Figures = new List<IFigure>();
            RemovedFigures = new List<IFigure>();
            PainterFont = new Font("Ariel", 12);
        }

        public void SetPictureBox(PictureBox pictureBox)
        {
            _pictureBox = pictureBox;
            _mainBitmap = new Bitmap(_pictureBox.Width, _pictureBox.Height);
            _tmpBitmap = (Bitmap)_mainBitmap.Clone();
            PainterGraphics = Graphics.FromImage(_tmpBitmap);
            _pictureBox.BackColor = Color.White;
            _pictureBox.Image = _tmpBitmap;
            Scale = 1;
            MouseHandler = new CursorMouseHandler();
        }

        public static Painter GetPainter()
        {
            if (_painter is null)
            {
                _painter = new Painter();
            }

            return _painter;
        }

        public void SetMainBitmap()
        {
            _mainBitmap = _tmpBitmap;
        }

        public void UpdatePictureBox()
        {
           _tmpBitmap = (Bitmap)_mainBitmap.Clone();
            _pictureBox.Image = _tmpBitmap;
            PainterGraphics = Graphics.FromImage(_tmpBitmap);
        }

        public void Clear()
        {
            _mainBitmap = new Bitmap(_pictureBox.Width, _pictureBox.Height);
            UpdatePictureBox();
        }

        public void Refresh()
        {
            Clear();

            foreach(IFigure fgr in Figures)
            {
                fgr.Draw();
            }

            SetMainBitmap();
        }

        public void ExportImage(string path)
        {
            using (var bitmap = new Bitmap(_pictureBox.Width, _pictureBox.Height))
            {
                _pictureBox.DrawToBitmap(bitmap, _pictureBox.ClientRectangle);
                ImageFormat imageFormat = null;

                var extension = Path.GetExtension(path);
                switch (extension)
                {
                    case ".bmp":
                        imageFormat = ImageFormat.Bmp;
                        break;
                    case ".png":
                        imageFormat = ImageFormat.Png;
                        break;
                    case ".jpg":
                        imageFormat = ImageFormat.Jpeg;
                        break;
                    case ".gif":
                        imageFormat = ImageFormat.Gif;
                        break;
                    default:
                        break;
                }

                bitmap.Save(path, imageFormat);
            }
        }

        public void SetRectanleShowPorts(bool showPorts)
        {
            foreach(IFigure fgr in Figures)
            {
                if(fgr is ClassRectangle)
                {
                    ((ClassRectangle)fgr).ShowPorts = showPorts;
                }
            }

            Refresh();
        }
    }
}
