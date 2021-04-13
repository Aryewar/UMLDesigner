using UMLDesigner.Figures.Arrows;

namespace UMLDesigner.Figures.Fabrics
{
    public class InharitanceArrowFabric : IFigureFabric
    {
        public IFigure GetFigure()
        {
            return new InharitanceArrow();
        }
    }
}
