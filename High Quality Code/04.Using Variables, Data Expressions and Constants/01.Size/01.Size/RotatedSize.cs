namespace Size
{
    using System;

    public class SizeRefactored
    {
        public static Size GetRotatedSize(Size initialSize, double angleOfTheFigure)
        {
            double newCosWidthSize = Math.Abs(Math.Cos(angleOfTheFigure)) * initialSize.Width;
            double newSinHeigthSize = Math.Abs(Math.Sin(angleOfTheFigure)) * initialSize.Heigth;
            double newSinWidthSize = Math.Abs(Math.Sin(angleOfTheFigure)) * initialSize.Width;
            double newCosHeigthSize = Math.Abs(Math.Cos(angleOfTheFigure)) * initialSize.Heigth;
            double fullWidthSize = newCosWidthSize + newSinWidthSize;
            double fullHeightSize = newCosHeigthSize + newSinHeigthSize;
            Size newSize = new Size(fullWidthSize, fullHeightSize);
            return newSize;
        }

        static public void Main()
        {
        }
    }
}