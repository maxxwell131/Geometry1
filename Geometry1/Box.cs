using System;

namespace Geometry1
{
    class Box:Shape
    {
        public Pixel corner1;
        public Pixel corner2;
        public int width;
        public int height;

        public Box
        (int x1, int y1, int x2, int y2): this(new Pixel( x1, y1), new Pixel(x2, y2))
        {
        }

        public Box(Pixel lu, Pixel rd)
        {
            this.corner1 = lu;
            this.corner2 = rd;
            width = Math.Abs(this.corner1.x - this.corner2.x);
            height = Math.Abs(this.corner1.y - this.corner2.y);
        }

        public void Draw()
        {
            graph.DrawRectangle(pen, corner1.x, corner1.y, width, height);
        }
    }

    
}
