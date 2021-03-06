using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    public class Rectangle : Shape
    {
        private double height;
        private double width;

        public double Height
        {
            get { return this.height; }
            private set { this.height = value; }
        }


        public double Width
        {
            get { return this.width; }
            private set { this.width = value; }
        }

        public override double CalculateArea()
        {
            return this.height * this.width;
        }

        public override double CalculatePerimeter()
        {
            return 2 * this.width + 2 * this.height;
        }

        public Rectangle(int height, int width)
        {
            this.Height = height;
            this.Width = width;
        }

        public override string Draw()
        {
            return base.Draw() + this.GetType().Name;
        }

    }
}
