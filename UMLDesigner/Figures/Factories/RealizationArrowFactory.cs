using UMLDesigner.Figures.Arrows;

namespace UMLDesigner.Figures.Factories
{
    public class RealizationArrowFactory : IFigureFactory
    {
        public IFigure GetFigure()
        {
            return new RealizationArrow();
        }
    }
}
