using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMLDesigner.Figures.Factories
{
    public interface IFigureFactory
    {
        IFigure GetFigure();
    }
}