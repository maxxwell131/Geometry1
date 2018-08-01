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



        ColorLine cl1;
        ColorLine cl2;

        ColorBox colorBox;

        Circle circle1;
        Circle circle2;
        Circle circle3;
        Line line1;
        Line line2;
        Box box1;
        Box box2;

        ColorCircle colorCircle;

        Pixel A, B, C, D, E, O, F, G, H, I, J, K, L ,M;

        public Geometry1()
        {
            InitializeComponent();
            InitSnowMan();
            Init();
            Draw();
        }

        private void Init()
        {
            bitmap = new Bitmap(pictureBox.Width, pictureBox.Height);
            graphics = Graphics.FromImage(bitmap);
            pen = new Pen(Color.Blue);

            /*
            A = new Pixel( 100, 300);
            B = new Pixel( 300, 300);
            C = new Pixel( 100, 100);
            D = new Pixel( 300, 100);
            E = new Pixel( 200, 10);
            O = new Pixel( 200, 200);

            line1 = new Line( C, E);
            line2 = new Line( E.x, E.y, D.x, D.y); //new Line( E, D); вызов второго конструктора

            box1 = new Box( C, B);
            colorBox = new ColorBox(O, B, Color.Green);

            circle1 = new Circle( O, 100);
            colorCircle = new ColorCircle( O, A, Color.Orange);

            cl1 = new ColorLine( A, D, Color.Red);
            cl2 = new ColorLine( B, C, Color.Red);
            */
        }

        private void InitSnowMan()
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

            circle1 = new Circle( A, D);
            circle2 = new Circle( B, D);
            circle3 = new Circle( C, E);

            line1 = new Line( F, G);
            line2 = new Line( H, I);

            box1 = new Box( J, K);
            box2 = new Box( L, M);
        }

        private void Draw()
        {
            //graphics.DrawRectangle( pen, 100, 100, 200, 200);
            Draw(box1);
            Draw(box2);
            Draw(line1);
            Draw(line2);
            Draw(circle1);
            Draw(circle2);
            Draw(circle3);
            pictureBox.Image = bitmap;
        }

        private void Draw(Line line)
        {
            graphics.DrawLine(pen, line.begin.x, line.begin.y, line.ended.x, line.ended.y);
        }

        private void Draw(ColorLine line)
        {
            graphics.DrawLine(line.pen, line.begin.x, line.begin.y, line.ended.x, line.ended.y);
        }

        private void Draw(Box box)
        {
            graphics.DrawRectangle(pen, box.corner1.x, box.corner1.y, box.width, box.height);
        }

        private void Draw(ColorBox box)
        {
            graphics.DrawRectangle(box.pen, box.corner1.x, box.corner1.y, box.width, box.height);
        }

        private void Draw(Circle circle)
        {
            graphics.DrawEllipse(pen, circle.corner.x, circle.corner.y, circle.width, circle.height);
        }

        private void Draw(ColorCircle circle)
        {
            graphics.DrawEllipse(circle.pen, circle.corner.x, circle.corner.y, circle.width, circle.height);
        }
    }
}
