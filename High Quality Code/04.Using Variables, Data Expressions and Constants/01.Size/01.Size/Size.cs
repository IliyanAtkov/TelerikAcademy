namespace Size
{
    using System;

    public class Size
    {
        public Size(double width, double heigth)
        {
            this.Width = width;
            this.Heigth = heigth;
        }

        public double Width { get; set; }

        public double Heigth { get; set; }
    }
}