using System.Drawing;

namespace Geometry1
{
    class Circle: Shape
    {
        public Pixel center;
        public int radius;
        public Pixel corner;
        public int width, height;

        protected Graphics graph;
        protected Pen pen;

        public void SetGraphics(Graphics graphics)
        {
            this.graph = graphics;
        }

        public void SetPen(Pen pen)
        {
            this.pen = pen;
        }

        public Circle(Pixel center, int radius)
        {
            this.center = center;
            this.radius = radius;
            this.corner = new Pixel( (this.center.x - this.radius), (this.center.y - this.radius));
            this.width = this.height = this.radius * 2;
        }

        public Circle(int x, int y, int radius)
            : this( new Pixel( x, y), radius)
        {
        }

        public Circle(Pixel center, Pixel pixel): this( center, center.distance(pixel))
        {
        }

        public void Draw()
        {
            graph.DrawEllipse(pen, corner.x, corner.y, width, height);

        }
    }
}
