namespace Shapes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public abstract class Shape
    {
        protected double Width { get; set;}
        protected double Height { get; set; }

        protected Shape(double width)  // more information why is protected in abstract class read here http://stackoverflow.com/questions/4116981/is-it-good-to-have-a-constructor-in-abstract-class
             : this(width, 0)
        {           
        }
        protected Shape(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public abstract double CalculateSurface();
    }
}
