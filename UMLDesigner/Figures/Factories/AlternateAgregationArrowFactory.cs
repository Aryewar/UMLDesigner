using UMLDesigner.Figures.Arrows;

namespace UMLDesigner.Figures.Factories
{
    public class AlternateAgragationArrowFactory : IFigureFactory
    {
        public IFigure GetFigure()
        {
            return new AlternateAgregationArrow();
        }
    }
}