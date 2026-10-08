using System;
using System.Collections.Generic;
using System.Text;

namespace taqsiriq2
{
    class ShapeHelper
    {
        public double CalculateArea(double radius)
        {
            return Math.PI * radius * radius;
        }

        public double CalculateArea(double width, double height)
        {
            return width * height;
        }
    }
}
