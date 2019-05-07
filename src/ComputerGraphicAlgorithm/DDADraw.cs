using System.Drawing;
using System.Windows.Forms;

namespace ComputerGraphicAlgorithm
{
    public class DDADraw : IDrawLineAlgorithm
    {
        Bitmap _bmp;
        PictureBox _convas;
        Color _color;
        public DDADraw(Bitmap bmp, Color color, ref PictureBox convas)
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
            float dx = (X2 - X1);
            float dy = (Y2 - Y1);
            int steps = (int)dy;
            if (dx > dy)
            {
                steps = (int)dx;
                float x_inc = (dx / (float)steps);
                float y_inc = (dy / (float)steps);
                float x = X1;
                float y = Y1;
                Bmp.SetPixel((int)x, (int)y, Color);
                for (int count = 1; count <= steps; count++)
                {
                    x += x_inc;
                    y += y_inc;
                    Bmp.SetPixel((int)(x + 0.5), (int)(y + 0.5), Color);
                }
            }
        }
    }
}
