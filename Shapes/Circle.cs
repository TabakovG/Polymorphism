using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    public class Circle : Shape
    {
        private double radius;

        public double Radius
        {
            get { return this.radius; }
            private set { this.radius = value; }
        }

        public override double CalculateArea()
        {
           // return Math.PI * this.Radius * this.Radius;
           return Math.Round((Math.PI * this.Radius * this.Radius), 2);
        }

        public override double CalculatePerimeter()
        {
            //return  2 * this.Radius * Math.PI;
            return Math.Round(( 2 * this.Radius * Math.PI), 2);
        }

        public Circle(int radius)
        {
            this.Radius = radius;
        }

        public override string Draw()
        {
            return base.Draw() + this.GetType().Name;
        }
    }
}
