using UMLDesigner.Figures.Arrows;

namespace UMLDesigner.Figures.Fabrics
{
    public class AgregationArrowFabric : IFigureFabric
    {
        public IFigure GetFigure()
        {
            return new AgregationArrow();
        }
    }
}
