namespace Euclian3DSpace
{
    using System;
  
    public static class DistanceBetweenTwoPoints
    {
        public static void DistanceCallculation(ThreeDCordinate point1, ThreeDCordinate point2)
        {
          double deltax = point2.x - point1.x;
          double deltay = point2.y - point1.y;
          double deltaz = point2.z - point1.z;
          double distance = (double)Math.Sqrt((deltax * deltax) + (deltay * deltay) + (deltaz * deltaz));
        }
    
    }
}
