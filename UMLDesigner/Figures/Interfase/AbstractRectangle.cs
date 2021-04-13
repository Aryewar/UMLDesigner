using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMLDesigner.Figures.Interfase
{
    public abstract class AbstractRectangle : IFigure
    {
        public Point StartPoint { get; set; }
        public Point FinishPoint { get; set; }
        public Pen FigurePen { get; set; }

        public void Draw()
        {
            throw new NotImplementedException();
        }

        public bool IsSelected(Point curentPoint)
        {
            throw new NotImplementedException();
        }

        public void Move(int deltaX, int deltaY)
        {
            throw new NotImplementedException();
        }
    }
}
