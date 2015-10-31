namespace Euclian3DSpace
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Path
    {
        private List<ThreeDCordinate> pointPath;

        public Path()
        {
            this.pointPath = new List<ThreeDCordinate>();
        }

        public Path(params ThreeDCordinate[] points) : this()
        {
            for (int i = 0; i < points.Length; i++)
            {
                this.pointPath.Add(points[i]);
            }
        }

        public List<ThreeDCordinate> PointPath
        {
            get { return new List<ThreeDCordinate>(this.pointPath);}
        }

        public void AddPoint(ThreeDCordinate point)
        {
            this.pointPath.Add(point);
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            foreach (var item in pointPath)
            {
                sb.AppendLine(item.ToString());
            }
            return sb.ToString();
        }
    }
}
