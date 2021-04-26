using UMLDesigner.Figures.Arrows;

namespace UMLDesigner.Figures.Factories
{
    public class AgregationArrowFactory : IFigureFactory
    {
        public IFigure GetFigure()
        {
            return new AgregationArrow();
        }
    }
}
