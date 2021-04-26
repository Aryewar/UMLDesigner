using UMLDesigner.Figures.Arrows;

namespace UMLDesigner.Figures.Factories
{
    public class AlternateCompositionArrowFactory : IFigureFactory
    {
        public IFigure GetFigure()
        {
            return new AlternateCompositionArrow();
        }
    }
}
