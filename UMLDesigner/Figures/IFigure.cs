using System.Collections.Generic;
using System.Drawing;
using Newtonsoft.Json;
using static UMLDesigner.Figures.SinglePainter.Painter;

namespace UMLDesigner.Figures
{
    public interface IFigure : IMovable
    {
        Point StartPoint { get; set; }
        Point FinishPoint { get; set; }
        Point PrevPosition { get; set; }
        [JsonIgnore]
        Pen FigurePen { get; set; }
        Font textFont { get; set; }

        int PenWidth { get; set; }
        Color PenColor { get; set; }
        FigureType figureType { get; set; }
        List<IFigure> Links { get; set; }

        string Type { get; set; }

        void Draw();
    }
}
