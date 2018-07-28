﻿using System.Drawing;
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

        Line line1;
        Line line2;
        Box box1;
        Circle circle1;
        Circle circle2;

        Pixel A, B, C, D, E, O;

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

            A = new Pixel( 100, 300);
            B = new Pixel( 300, 300);
            C = new Pixel( 100, 100);
            D = new Pixel( 300, 100);
            E = new Pixel( 200, 10);
            O = new Pixel( 200, 200);

            line1 = new Line( C, E);
            line2 = new Line( E.x, E.y, D.x, D.y); //new Line( E, D); вызов второго конструктора
            box1 = new Box( C, B);
            circle1 = new Circle( O, 100);
            circle2 = new Circle( O, A);
        }

        private void Draw()
        {
            //graphics.DrawRectangle( pen, 100, 100, 200, 200);
            Draw(box1);
            Draw(line1);
            Draw(line2);
            Draw(circle1);
            Draw(circle2);
            pictureBox.Image = bitmap;
        }

        private void Draw(Line line)
        {
            graphics.DrawLine(pen, line.begin.x, line.begin.y, line.ended.x, line.ended.y);
        }

        private void Draw(Box box)
        {
            graphics.DrawRectangle(pen, box.corner1.x, box.corner1.y, box.width, box.height);
        }

        private void Draw(Circle circle)
        {
            graphics.DrawEllipse(pen, circle.corner.x, circle.corner.y, circle.width, circle.height);
        }
    }
}