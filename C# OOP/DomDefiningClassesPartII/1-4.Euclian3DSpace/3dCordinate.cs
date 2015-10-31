namespace Euclian3DSpace
{
    using System;

    public struct ThreeDCordinate
    {
        private static readonly ThreeDCordinate startCoord = new ThreeDCordinate(0, 0, 0);
        public double x { get; set; }
        public double y { get; set; }
        public double z { get; set; }

        public ThreeDCordinate(double X, double Y, double Z)
            : this()
        {
            this.x = X;
            this.y = Y;
            this.z = Z;
        }

        public ThreeDCordinate StartCoord
        {
            get { return startCoord; }
        }
        
        public override string ToString()
        {
            return string.Format("X: {0}, Y: {1}, Z: {2}", x, y, z);
        }
   
    }
}
