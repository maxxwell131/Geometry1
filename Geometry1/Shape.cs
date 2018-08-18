using System.Drawing;

namespace Geometry1
{
    abstract class Shape
    {
        Pixel pixel;
        protected Pixel position;
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

        abstract public void Draw();

        virtual public void Move(Pixel position)
        {
            this.position = position;
        }
    }
}
