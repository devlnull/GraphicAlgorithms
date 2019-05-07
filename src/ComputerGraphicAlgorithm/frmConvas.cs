using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace ComputerGraphicAlgorithm
{
    public partial class frmConvas : Form
    {
        public frmConvas()
        {
            InitializeComponent();
        }
        public Bitmap Bmp = new Bitmap(760, 984);
        private void btnBersenham_Click(object sender, EventArgs e)
        {
            IDrawLineAlgorithm line = new BersenhamDraw(Bmp, Color.Black, ref Convas);
            Draw(line);
        }
        private void btnDDA_Click(object sender, EventArgs e)
        {
            IDrawLineAlgorithm line = new DDADraw(Bmp, Color.Black, ref Convas);
            Draw(line);
        }
        void Draw(IDrawLineAlgorithm line)
        {
            try
            {
                int X1 = trackX1.Value;
                int Y1 = trackY1.Value;
                int X2 = trackX2.Value;
                int Y2 = trackY2.Value;
                line.Draw(X1, X2, Y1, Y2);
            }
            catch { MessageBox.Show("رنج وارد شده خارج از محدوده ی بوم است."); }
        }
        private void btnDrawCircle_Click(object sender, EventArgs e)
        {
            try
            {
                IDrawCircleAlgorithm circle = new DrawCircle(Bmp, Color.Black, ref Convas);
                circle.Draw(trackXc.Value, trackYc.Value, trackRaduis.Value);
            }
            catch { MessageBox.Show("رنج وارد شده خارج از محدوده ی بوم است."); }
        }
        void refreshLabels()
        {
            lblRadiusValue.Text = trackRaduis.Value.ToString();
            lblX1Value.Text = trackX1.Value.ToString();
            lblX2Value.Text = trackX2.Value.ToString();
            lblY1Value.Text = trackY1.Value.ToString();
            lblY2Value.Text = trackY2.Value.ToString();
            lblYcValue.Text = trackYc.Value.ToString();
            lblXcValue.Text = trackXc.Value.ToString();
        }
        private void ValueChanged(object sender, EventArgs e) => refreshLabels();

        private void btnRandomLine_Click(object sender, EventArgs e)
        {
            try
            {
                Random rnd = new Random();
                IDrawLineAlgorithm line = new BersenhamDraw(Bmp, Color.Red, ref Convas);
                int X1 = rnd.Next(1, Bmp.Width);
                Thread.Sleep(10);
                int X2 = rnd.Next(1, Bmp.Width);
                Thread.Sleep(10);
                int Y1 = rnd.Next(1, Bmp.Height);
                Thread.Sleep(10);
                int Y2 = rnd.Next(1, Bmp.Height);
                line.Draw(X1, X2, Y1, Y2);
            }
            catch { MessageBox.Show("رنج وارد شده خارج از محدوده ی بوم است."); }
        }
        private void btnRandomCircle_Click(object sender, EventArgs e)
        {
            try
            {
                Random rnd = new Random();
                IDrawCircleAlgorithm line = new DrawCircle(Bmp, Color.Red, ref Convas);
                int Xc = rnd.Next(1, Bmp.Width);
                Thread.Sleep(10);
                int Yc = rnd.Next(1, Bmp.Height);
                Thread.Sleep(10);
                int R = rnd.Next(1, 500);
                line.Draw(Xc, Yc, R);
            }
            catch { MessageBox.Show("رنج وارد شده خارج از محدوده ی بوم است."); }
        }
    }
}
