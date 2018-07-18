using System.Drawing;
using System.Windows.Forms;

namespace Geometry1
{
    public partial class Geometry1 : Form
    {
        Bitmap bitmap;
        Graphics graphics;
        Pen pen;

        Line line1;
        Line line2;
        Box box1;
        Circle circle1;

        public Geometry1()
        {
            InitializeComponent();
            Init();
            Draw();
        }

        private void Init()
        {
            bitmap = new Bitmap(pictureBox.Width, pictureBox.Height);
            graphics = Graphics.FromImage(bitmap);
            pen = new Pen(Color.Blue);
            line1 = new Line(100, 100, 200, 10);
            line2 = new Line(200, 10, 300, 100);
            box1 = new Box(100, 100, 300, 300);
            circle1 = new Circle( 200, 200, 100);
        }

        private void Draw()
        {
            //graphics.DrawRectangle( pen, 100, 100, 200, 200);
            Draw(box1);
            Draw(line1);
            Draw(line2);
            Draw(circle1);
            pictureBox.Image = bitmap;
        }

        private void Draw(Line line)
        {
            graphics.DrawLine(pen, line.x1, line.y1, line.x2, line.y2);
        }

        private void Draw(Box box)
        {
            graphics.DrawRectangle(pen, box.x1, box.y1, box.width, box.height);
        }

        private void Draw(Circle circle)
        {
            graphics.DrawEllipse(pen, circle.x1, circle.y1, circle.width, circle.height);
        }
    }
}
