using System.Drawing;
using System.Windows.Forms;

namespace ComputerGraphicAlgorithm
{
    public interface IDrawLineAlgorithm
    {
        void Draw(int X1, int X2, int Y1, int Y2);
    }
    public interface IDrawCircleAlgorithm
    {
        void Draw(int Xc, int Yc, int R);
    }
}
