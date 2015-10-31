// Write methods that calculate the surface of a triangle by given:
// Side and an altitude to it; Three sides; Two sides and an angle between them. 
// Use System.Math.

using System;



class SurfaceOfTriangle
{
    
    static double GetAreaHeron(double a, double b, double c)
    {
        double p = (a + b + c) / 2;

        return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
    }

    static double GetAreaAltitude(double a, double h)
    {
        return (a * h) / 2;
    }


    static double GetAreaAngle(double a, double b, double alpha)
    {
        return (a * b * Math.Sin(Math.PI * alpha / 180)) / 2;
    }

    static void Main()
    {
        Console.WriteLine("Area Altitude");
        Console.WriteLine(GetAreaAltitude(a: 2, h: 4));
        Console.WriteLine();
        Console.WriteLine("Area Heron");
        Console.WriteLine(GetAreaHeron(a: 5, b: 6, c: 7));
        Console.WriteLine();
        Console.WriteLine("Area Angle");
        Console.WriteLine(GetAreaAngle(a: 1, b: 5, alpha: 120));
    }
}

