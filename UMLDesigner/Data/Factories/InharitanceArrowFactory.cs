using UMLDesigner.Figures.Arrows;

namespace UMLDesigner.Figures.Factories
{
    public class InharitanceArrowFactory : IFigureFactory
    {
        public IFigure GetFigure()
        {
            return new InharitanceArrow();
        }
    }
}
