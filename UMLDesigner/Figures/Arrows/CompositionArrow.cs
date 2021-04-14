using System.Drawing;
using System.Drawing.Drawing2D;

namespace UMLDesigner.Figures.Arrows
{
    public class CompositionArrow : AbstractArrow
    {
        public CompositionArrow()
        {
            FigurePen = new Pen(_painter.PainterPen.Color, _painter.PainterPen.Width);
            GraphicsPath hPath = new GraphicsPath();
            Point[] filledRhombus = new Point[] { new Point(0, 0),
                                                    new Point(3, 6),
                                                    new Point(0, 12),
                                                    new Point(-3, 6)
                                                  };

            hPath.AddPolygon(filledRhombus);
            FigurePen.CustomEndCap = new CustomLineCap(null, hPath);
        }
    }
}
