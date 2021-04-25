using UMLDesigner.Figures.Arrows;

namespace UMLDesigner.Figures.Fabrics
{
    public class AlternateAgragationArrowFabric : IFigureFabric
    {
        public IFigure GetFigure()
        {
            return new AlternateAgregationArrow();
        }
    }
}