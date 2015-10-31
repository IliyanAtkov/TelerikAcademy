namespace Shapes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Circle : Shape
    {
        public Circle(int radius)
            : base(radius)
        {
        }
        public override double CalculateSurface()
        {
            return Math.PI * this.Width * 2;
        }
    }
}
