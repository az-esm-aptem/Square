using System;
using System.Collections.Generic;
using System.Text;

namespace Square
{
    public class Point
    {

        public double x { get; private set;}
        public double y { get; private set; }
        public Point(double xx, double yy)
        {
            x = xx;
            y = yy;
        }
    }
}
