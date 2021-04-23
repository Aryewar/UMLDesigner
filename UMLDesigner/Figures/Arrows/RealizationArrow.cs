using System.Drawing;
using System.Drawing.Drawing2D;

namespace UMLDesigner.Figures.Arrows
{
    public class RealizationArrow : AbstractArrow
    {
        public RealizationArrow()
        {
            PenWidth = (int)_painter.PainterPen.Width;
            PenColor = _painter.PainterPen.Color;
            FigurePen = new Pen(PenColor, PenWidth);

            GraphicsPath hPath = new GraphicsPath();
            Point[] emptyTriangle = new Point[] { new Point(-6, 0),
                                                    new Point(6, 0),
                                                    new Point(0, 12),
                                                  };

            hPath.AddPolygon(emptyTriangle);
            FigurePen.CustomEndCap = new CustomLineCap(null, hPath);
            FigurePen.DashStyle = DashStyle.Dash;

            figureType = SinglePainter.Painter.FigureType.RealizationArrow;
        }
        
    }
}
