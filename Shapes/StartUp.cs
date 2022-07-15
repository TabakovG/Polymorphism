using System;

namespace Shapes
{
    public class StartUp
    {
        static void Main()
        {
            var rec = new Rectangle(3,4);
            Console.WriteLine(rec.Draw());
            Console.WriteLine(rec.CalculateArea());
            Console.WriteLine(rec.CalculatePerimeter());
            
            var cir = new Circle(5);
            Console.WriteLine(cir.Draw());
            Console.WriteLine(cir.CalculateArea());
            Console.WriteLine(cir.CalculatePerimeter());

        }
    }
}
