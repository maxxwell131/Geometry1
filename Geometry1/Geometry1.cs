using System;
using System.Drawing;
using System.Windows.Forms;

namespace Geometry1
{
    public struct Pixel
    {
        public int x;
        public int y;

        public Pixel( int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public int distance(Pixel pixel)
        {
            return System.Convert.ToInt32(System.Math.Sqrt((this.x - pixel.x) * (this.x - pixel.x) +
                                        (this.y - pixel.y) * (this.y - pixel.y)));
        }
    }

    public partial class Geometry1 : Form
    {
        Bitmap bitmap;
        Graphics graphics;
        Pen pen;

        Shape[] snowMan1;
        Shape[] snowMan2;

        Pixel A, B, C, D, E, O, F, G, H, I, J, K, L ,M;

        public Geometry1()
        {
            InitializeComponent();
            Init();
            InitSnowMan1();
            InitSnowMan2();
            Draw();
        }

        private void Init()
        {
            bitmap = new Bitmap(pictureBox.Width, pictureBox.Height);
            graphics = Graphics.FromImage(bitmap);
            pen = new Pen(Color.Blue);
        }

        private void InitSnowMan1()
        {
            A = new Pixel( 219, 63);
            B = new Pixel( 220, 177);
            C = new Pixel( 223, 401);
            D = new Pixel( 218, 98);
            E = new Pixel( 221, 259);
            F = new Pixel( 158, 129);
            G = new Pixel( 64, 200);
            H = new Pixel( 282, 131);
            I = new Pixel( 366, 200);
            J = new Pixel( 140, 493);
            K = new Pixel( 188, 537);
            L = new Pixel( 242, 492);
            M = new Pixel( 283, 534);

            snowMan1 = new Shape[7];

            snowMan1[0] = new Circle( A, D); //circle1
            

            snowMan1[1] = new Circle( B, D); //circle2       
            snowMan1[2] = new Circle( C, E); //circle3
            snowMan1[3] = new Line( F, G); //line1
            snowMan1[4] = new Line( H, I); //line2
            snowMan1[5] = new Box( J, K); //box1
            snowMan1[6] = new Box( L, M); //box2

            foreach (Shape item in snowMan1)
            {
                item.SetGraphics(graphics);
            }
        }

        private void InitSnowMan2()
        {
            int delta = 400;
            A = new Pixel( delta + 219, 63);
            B = new Pixel( delta + 220, 177);
            C = new Pixel( delta + 223, 401);
            D = new Pixel( delta + 218, 98);
            E = new Pixel( delta + 221, 259);
            F = new Pixel( delta + 158, 129);
            G = new Pixel( delta + 64, 200);
            H = new Pixel( delta + 282, 131);
            I = new Pixel( delta + 366, 200);
            J = new Pixel( delta + 140, 493);
            K = new Pixel( delta + 188, 537);
            L = new Pixel( delta + 242, 492);
            M = new Pixel( delta + 283, 534);

            snowMan2 = new Shape[7];

            snowMan2[0] = new ColorCircle( A, D, Color.Red); //circle21
            snowMan2[1] = new ColorCircle( B, D, Color.Orange);
            snowMan2[2] = new ColorCircle( C, E, Color.Green);

            snowMan2[3] = new ColorLine( F, G, Color.Blue);
            snowMan2[4] = new ColorLine( H, I, Color.Blue);

            snowMan2[5] = new ColorBox( J, K, Color.Red);
            snowMan2[6] = new ColorBox( L, M, Color.Red);

            foreach (Shape item in snowMan2)
            {
                item.SetGraphics(graphics);
            }
        }

        private void Draw()
        {
            Draw(snowMan1);
            Draw(snowMan2);
            pictureBox.Image = bitmap;
        }

        private void Draw(Shape[] shapes)
        {
            for (int i = 0; i < shapes.Length; i++)
            {
                shapes[i].Draw();
            }
        }
    }
}
