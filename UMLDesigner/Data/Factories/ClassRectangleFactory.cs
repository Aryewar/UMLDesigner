using UMLDesigner.Figures.Rectangles;

namespace UMLDesigner.Figures.Factories
{
    public class ClassRectangleFactory : IFigureFactory
    {
        public IFigure GetFigure()
        {
            return new ClassRectangle();
        }
    }
}
