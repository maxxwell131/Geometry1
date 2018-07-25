﻿namespace Geometry1
{
    class Line
    {
        public int x1, y1;
        public int x2, y2;


        public Line(Pixel begin, Pixel ended)
        {
            this.x1 = begin.x;
            this.y1 = begin.y;

            this.x2 = ended.x;
            this.y2 = ended.y;
        }

        public Line( int x1, int y1, int x2, int y2)
        {
            this.x1 = x1;
            this.x2 = x2;
            this.y1 = y1;
            this.y2 = y2;
        }
    }
}
