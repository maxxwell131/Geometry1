namespace Geometry1
{
    class Circle
    {
        public Pixel center;
        public int radius;
        public Pixel corner;
        public int width, height;

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
    }
}
