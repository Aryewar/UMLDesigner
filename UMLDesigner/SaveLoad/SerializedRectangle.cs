using System.Collections.Generic;
using System.Drawing;
using System.Text;
using static UMLDesigner.Figures.SinglePainter.Painter;

namespace UMLDesigner.SaveLoad
{
    public class SerializedRoot
    {
        public List<SerializedRectangle> SerializedRectangles{ get;set; }
        public SerializedRoot()
        {
            SerializedRectangles = new List<SerializedRectangle>();
        }
    }

    public class SerializedPort
    {
        public FigureType FigureType { get; set; }
        public int PortId { get; set; }
        public int RectangleId { get; set; }

        public SerializedPort()
        {

        }
    }

    public class SerializedRectangle
    {
        public Point StartPoint { get; set; }
        public int Width { get; set; }
        public Color PenColor { get; set; }
        public Color BackColor { get; set; }
        public string Title { get; set; }
        public List<SerializedPort> Ports { get; set; } 

        public SerializedRectangle()
        {
            Ports = new List<SerializedPort>();
        }
    }

    public class SerializedArrow
    {
        public Point StartPoint { get; set; }
        public int Width { get; set; }
        public Color PenColor { get; set; }
        public StringBuilder Title { get; set; }
        public List<int> Links { get; set; }

        public SerializedArrow()
        {
            Links = new List<int>();
        }
    }
}
