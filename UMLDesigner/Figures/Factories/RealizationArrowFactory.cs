using UMLDesigner.Figures.Arrows;

namespace UMLDesigner.Figures.Fabrics
{
    public class RealizationArrowFabric : IFigureFabric
    {
        public IFigure GetFigure()
        {
            return new RealizationArrow();
        }
    }
}
