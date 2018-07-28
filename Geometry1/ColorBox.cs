using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Threading.Tasks;

namespace Geometry1
{
    class ColorBox
    {
        public Pixel corner1;
        public Pixel corner2;
        public int width;
        public int height;
        public Pen pen;

        public ColorBox
        (int x1, int y1, int x2, int y2, Color color) : this(new Pixel(x1, y1), new Pixel(x2, y2),  color)
        {
        }

        public ColorBox(Pixel lu, Pixel rd, Color color)
        {
            this.corner1 = lu;
            this.corner2 = rd;
            width = Math.Abs(this.corner1.x - this.corner2.x);
            height = Math.Abs(this.corner1.y - this.corner2.y);
            this.pen = new Pen(color);
        }
    }
}
