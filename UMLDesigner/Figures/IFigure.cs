using System.Collections.Generic;
using System.Drawing;

namespace UMLDesigner.Figures
{
    public interface IFigure : IMovable
    {
        Point StartPoint { get; set; }
        Point FinishPoint { get; set; }
        Point PrevPosition { get; set; }
        Pen FigurePen { get; set; }
        Font textFont { get; set; }
        List<IFigure> Links { get; set; }

        void Draw();
    }
}
