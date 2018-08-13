using System.Drawing;

namespace Geometry1
{
    class Shape
    {
        Pixel pixel;
        protected Graphics graph;
        protected Pen pen;

        public Shape()
        {
            pen = new Pen(Color.Black);
        }

        public void SetGraphics(Graphics graphics)
        {
            this.graph = graphics;
        }

    }
}
