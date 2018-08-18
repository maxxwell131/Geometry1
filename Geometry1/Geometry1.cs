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

        Sprite snowMan1;
        Sprite snowMan2;

        Circle circle;
        Box box;
        Line line;

        Pixel A, B, C, D, E, O, F, G, H, I, J, K, L ,M;

        public Geometry1()
        {
            InitializeComponent();
            Init();

            Demo();
            //InitSnowMan1();
            //InitSnowMan2();
            //Draw();
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

            snowMan1 = new Sprite();
            snowMan1.SetGraphics(graphics);
            snowMan1.AddShape(new Circle( A, D)); //circle1
            snowMan1.AddShape(new Circle( B, D)); //circle2       
            snowMan1.AddShape(new Circle( C, E)); //circle3
            snowMan1.AddShape(new Line( F, G)); //line1
            snowMan1.AddShape(new Line( H, I)); //line2
            snowMan1.AddShape(new Box( J, K)); //box1
            snowMan1.AddShape(new Box( L, M)); //box2
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

            snowMan2 = new Sprite();
            snowMan2.SetGraphics(graphics);
            snowMan2.AddShape(new ColorCircle( A, D, Color.Red)); //circle21
            snowMan2.AddShape(new ColorCircle( B, D, Color.Orange));
            snowMan2.AddShape(new ColorCircle( C, E, Color.Green));

            snowMan2.AddShape(new ColorLine( F, G, Color.Blue));
            snowMan2.AddShape(new ColorLine( H, I, Color.Blue));

            snowMan2.AddShape(new ColorBox( J, K, Color.Red));
            snowMan2.AddShape(new ColorBox( L, M, Color.Red));
        }

        private void Draw()
        {
            snowMan1.Draw();
            snowMan2.Draw();
            pictureBox.Image = bitmap;
        }

        private void buttonMoveMe_Click(object sender, EventArgs e)
        {
            Pixel pixelMove = new Pixel(150, 200);

            circle.Move(pixelMove);
            circle.Draw();

            line.Move(pixelMove);
            line.Draw();

            box.Move(pixelMove);
            box.Draw();

            pictureBox.Image = bitmap;
        }

        private void Demo()
        {
            Pixel pixelMove = new Pixel(100, 100);
            A = new Pixel( 0, 0);
            circle = new Circle( A, 20);
            circle.SetGraphics(graphics);
            circle.Move(pixelMove);
            circle.Draw();

            line = new Line( 0, 20, 0 ,100);
            line.SetGraphics(graphics);
            line.Move(pixelMove);
            line.Draw();

            box = new Box( -20, -20, 20, -40);
            box.SetGraphics(graphics);
            box.Move(pixelMove);
            box.Draw();

            pictureBox.Image = bitmap;

        }
    }
}
