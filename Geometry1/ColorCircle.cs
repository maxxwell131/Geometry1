using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Threading.Tasks;

namespace Geometry1
{
    class ColorCircle
    {
        public Pixel center;
        public int radius;
        public Pixel corner;
        public int width, height;
        public Pen pen;

        public ColorCircle(Pixel center, int radius, Color color)
        {
            this.center = center;
            this.radius = radius;
            this.corner = new Pixel((this.center.x - this.radius), (this.center.y - this.radius));
            this.width = this.height = this.radius * 2;
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
