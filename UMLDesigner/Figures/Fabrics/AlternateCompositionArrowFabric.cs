using UMLDesigner.Figures.Arrows;

namespace UMLDesigner.Figures.Fabrics
{
    public class AlternateCompositionArrowFabric : IFigureFabric
    {
        public IFigure GetFigure()
        {
            return new AlternateCompositionArrow();
        }
    }
}
