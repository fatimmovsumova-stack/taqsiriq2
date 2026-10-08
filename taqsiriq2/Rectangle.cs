using System;
using System.Collections.Generic;
using System.Text;

namespace taqsiriq2
{
    class Rectangle: IShape
    {
        private double width;
        private double height;

        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        public double CalculateArea()
        {
            return width * height;
        }

        public double CalculatePerimeter()
        {
            return 2 * (width + height);
        }
    }
}
