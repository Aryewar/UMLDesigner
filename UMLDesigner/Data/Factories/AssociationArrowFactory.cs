using UMLDesigner.Figures.Arrows;

namespace UMLDesigner.Figures.Factories
{
    public class AssociationArrowFactory : IFigureFactory
    {
        public IFigure GetFigure()
        {
            return new AssociationArrow();
        }
    }
}
