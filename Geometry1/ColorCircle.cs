using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Threading.Tasks;

namespace Geometry1
{
    class ColorCircle: Circle
    {
        public ColorCircle(Pixel center, int radius, Color color): base(center, radius)
        {
            this.pen = new Pen(color);
        }

        public ColorCircle(int x, int y, int radius, Color color)
            : this(new Pixel(x, y), radius, color)
        {
        }

        public ColorCircle(Pixel center, Pixel pixel, Color color) : this(center, center.distance(pixel), color)
        {
            
        }
    }
}
