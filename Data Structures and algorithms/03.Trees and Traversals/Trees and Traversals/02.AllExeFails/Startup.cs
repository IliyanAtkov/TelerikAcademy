namespace AllExeFails
{
    using System;
    using System.IO;
    
    public class Startup
    {
        static void Main()
        {
            TraverseDirectory("C://Windows", "*.exe");

        }

        private static void TraverseDirectory(string directory, string seachPattern)
        {
            try
            {
                var files = Directory.GetFiles(directory, seachPattern);
                foreach (var file in files)
                {
                    Console.WriteLine(file);
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("{0} {1}", ex.Message, directory);
                return;
            }

            var directories = Directory.GetDirectories(directory);
            foreach (var dic in directories)
            {
                TraverseDirectory(dic, seachPattern);
            }
        }
    }
}