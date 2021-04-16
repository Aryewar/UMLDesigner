using System.Drawing;

namespace UMLDesigner.Figures
{
    public interface IMovable
    {
        bool IsSelected(Point currentPoint);
        void Move(int deltaX, int deltaY);
    }
}
