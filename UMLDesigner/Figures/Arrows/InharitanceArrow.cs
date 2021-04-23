using System.Drawing;
using System.Drawing.Drawing2D;

namespace UMLDesigner.Figures.Arrows
{
    public class InharitanceArrow : AbstractArrow
    {
        public InharitanceArrow()
        {
            FigurePen = new Pen(_painter.PainterPen.Color, _painter.PainterPen.Width);
            GraphicsPath hPath = new GraphicsPath();
            Point[] emptyTriangle = new Point[] { new Point(-6, 0),
                                                    new Point(6, 0),
                                                    new Point(0, 12),
                                                  };

            hPath.AddPolygon(emptyTriangle);
            FigurePen.CustomEndCap = new CustomLineCap(null, hPath);

            figureType = SinglePainter.Painter.FigureType.InharitanceArrow;
        }
    }
}
