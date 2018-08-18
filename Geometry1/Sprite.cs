using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry1
{
    class Sprite : Shape
    {
        List<Shape> shapes;

        public Sprite()
        {
            shapes = new List<Shape>();
        }

        public void AddShape(Shape shape)
        {
            shape.SetGraphics(graph);
            shapes.Add(shape);
        }

        public void Clear()
        {
            shapes.Clear();
        }

        override public void Draw()
        {
            foreach (Shape item in shapes)
            {
                item.Draw();
            }
        }

        override public void Move(Pixel position)
        {
            base.Move(position);
            foreach (Shape shape in shapes)
            {
                shape.Move(position);
            }
        }
    }
}
