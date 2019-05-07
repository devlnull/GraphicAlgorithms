using System.Drawing;
using System.Windows.Forms;

namespace ComputerGraphicAlgorithm
{
    class DrawCircle : IDrawCircleAlgorithm
    {
        Bitmap _bmp;
        PictureBox _convas;
        Color _color;
        public DrawCircle(Bitmap bmp, Color color, ref PictureBox convas)
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
        private void PolatePoint(int x, int y, int xc, int yc)
        {
            Convas.Image = Bmp;
            Bmp.SetPixel(xc + x, yc + y, Color);
            Bmp.SetPixel(xc + y, yc + x, Color);
            Bmp.SetPixel(xc + y, yc - x, Color);
            Bmp.SetPixel(xc + x, yc - y, Color);
            Bmp.SetPixel(xc - x, yc - y, Color);
            Bmp.SetPixel(xc - y, yc - x, Color);
            Bmp.SetPixel(xc - y, yc + x, Color);
            Bmp.SetPixel(xc - x, yc + y, Color);
        }
        public void Draw(int Xc, int Yc, int R)
        {
            int x, y, p;
            x = 0;
            y = R;
            p = 1 - R;
            PolatePoint(x, y, Xc, Yc);
            while (x <= y)
            {
                x++;
                if (p < 0)
                    p += (2 * x) + 1;
                else
                {
                    y--;
                    p += (2 * (x - y)) + 1;
                }
                PolatePoint(x, y, Xc, Yc);
            }
        }
    }
}
