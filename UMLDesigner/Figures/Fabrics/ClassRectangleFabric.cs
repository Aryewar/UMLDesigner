using UMLDesigner.Figures.Rectangles;

namespace UMLDesigner.Figures.Fabrics
{
    public class ClassRectangleFabric : IFigureFabric
    {
        public IFigure GetFigure()
        {
            return new ClassRectangle();
        }
    }
}
