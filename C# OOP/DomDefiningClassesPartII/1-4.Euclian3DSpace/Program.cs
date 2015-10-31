namespace Euclian3DSpace
{
    using System;

    public class Program
    {
        static void Main()
        {
            Path path = new Path();
            path.AddPoint(new ThreeDCordinate(3, 5, 6));
            path.AddPoint(new ThreeDCordinate(2, 6, 13));
            path.AddPoint(new ThreeDCordinate(1.5, 2.5, 3.4));
            PathStorage.SavePath(path);
            Path result = PathStorage.LoadPath();
            Console.WriteLine(result.ToString());
        }
    }
}
