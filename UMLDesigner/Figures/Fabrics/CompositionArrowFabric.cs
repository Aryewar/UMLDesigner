using UMLDesigner.Figures.Arrows;

namespace UMLDesigner.Figures.Fabrics
{
    public class CompositionArrowFabric : IFigureFabric
    {
        public IFigure GetFigure()
        {
            return new CompositionArrow();
        }
    }
}