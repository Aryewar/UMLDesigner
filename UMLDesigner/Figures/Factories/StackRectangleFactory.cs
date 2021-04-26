using UMLDesigner.Figures.Rectangles;

namespace UMLDesigner.Figures.Factories
{
    public class StackRectangleFactory : IFigureFactory
    {
        public IFigure GetFigure()
        {
            return new ClassRectangle() { IsStack = true };
        }
    }
}
