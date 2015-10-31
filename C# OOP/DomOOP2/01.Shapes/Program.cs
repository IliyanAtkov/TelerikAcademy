namespace Shapes
{
    using System;

    class Program
    {
        static void Main()
        {
            Shape[] shapess = 
            {
                new Rectangle(3, 8),
                new Rectangle(3.5, 4.5),
                new Circle(5),
                new Triangle(5,10)
            };

            foreach (var shape in shapess)
            {
                Console.WriteLine(shape.CalculateSurface());
            }
        }
    }
}
