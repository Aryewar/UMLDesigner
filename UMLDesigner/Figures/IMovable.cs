using System.Drawing;

namespace UMLDesigner.Figures
{
    public interface IMovable
    {
        bool IsSelected(Point curentPoint);
        void Move(int deltaX, int deltaY);
    }
}
