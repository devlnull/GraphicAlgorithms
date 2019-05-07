using System.Drawing;
using System.Windows.Forms;

namespace ComputerGraphicAlgorithm
{
    public class BersenhamDraw : IDrawLineAlgorithm
    {
        Bitmap _bmp;
        PictureBox _convas;
        Color _color;
        public BersenhamDraw(Bitmap bmp, Color color, ref PictureBox convas)
        {
            Convas = convas;
            Bmp = bmp;
            Color = color;
        }

        public Bitmap Bmp
        {
            get
            {
                return _bmp;
            }

            set
            {
                _bmp = value;
            }
        }

        public PictureBox Convas
        {
            get
            {
                return _convas;
            }
            set
            {
                _convas = value;
            }
        }

        public Color Color
        {
            get
            {
                return _color;
            }

            set
            {
                _color = value;
            }
        }

        public void Draw(int X1, int X2, int Y1, int Y2)
        {
            Convas.Image = Bmp;
            int x1 = X1;
            int x2 = X2;
            int y1 = Y1;
            int y2 = Y2;
            if (X1 > X2)
            {
                X1 = x2;
                Y1 = y2;
                X2 = x1;
                Y2 = y1;
            }
            int dx = X2 - X1;
            int dy = Y2 - Y1;
            int two_dy = 2 * dy;
            int two_dy_dx = (2 * (dy - dx));
            int p = ((2 * dy) - dx);
            int x = X1;
            int y = Y2;
            Bmp.SetPixel(x, y, Color);
            while (x < X2)
            {
                x++;
                if (p < 0)
                    p += two_dy;
                else
                {
                    y--;
                    p += two_dy_dx;
                }
                Bmp.SetPixel(x, y, Color);
            }
        }
    }
}
