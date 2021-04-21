using System.Drawing;
using System.Drawing.Drawing2D;
using UMLDesigner.Figures.SinglePainter;

namespace UMLDesigner.Figures.Arrows
{
    public class AlternateCompositionArrow : AbstractArrow
    {
        public AlternateCompositionArrow()
        {
            FigurePen = new Pen(_painter.PainterPen.Color, _painter.PainterPen.Width);

            GraphicsPath hPath = new GraphicsPath();
            Point[] filledRhombus = new Point[] { new Point(0, 0),
                                                    new Point(3, 6),
                                                    new Point(0, 12),
                                                    new Point(-3, 6)
                                                  };

            hPath.AddPolygon(filledRhombus);
            FigurePen.CustomStartCap = new CustomLineCap(null, hPath);
            FigurePen.CustomEndCap = new AdjustableArrowCap(9, 9, false);
            FigureType = Painter.FigureType.AlternateCompositionArrow.ToString();
        }
        
    }
}
