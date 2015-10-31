
namespace Euclian3DSpace
{
    using System;
    using System.Collections.Generic;
    using System.IO;


    public static class PathStorage
    {
    public static void SavePath(Path path)
        {
            StreamWriter write = new StreamWriter(@"../../result.txt");
            using (write)
            {
                foreach (var item in path.PointPath)
                {
                    write.WriteLine(String.Format("{0}-{1}-{2}", item.x, item.y, item.z));
                    write.Flush();
                }
            }

        }
    public static Path LoadPath()
        {
            Path loadedPath = new Path();
            try
            {            
                StreamReader read = new StreamReader(@"../../result.txt");
                using (read)
                {
                    while (read.Peek() >= 0)
                    {
                        string row = read.ReadLine();
                        string[] splitRow = row.Split(new char[] { '-', ' ', ','}, StringSplitOptions.RemoveEmptyEntries);
                        loadedPath.AddPoint(new ThreeDCordinate(double.Parse(splitRow[0]), double.Parse(splitRow[1]), double.Parse(splitRow[2])));
                    }
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File not found!!");
            }
            return loadedPath;
        }

    }
}
