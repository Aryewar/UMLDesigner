using UMLDesigner.Figures.Arrows;

namespace UMLDesigner.Figures.Fabrics
{
    public class AssociationArrowFabric : IFigureFabric
    {
        public IFigure GetFigure()
        {
            return new AssociationArrow();
        }
    }
}
