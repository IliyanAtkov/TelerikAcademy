namespace Students
{
    using System;
    using System.Linq;
    using System.IO;
    using System.Collections.Generic;

    public class Startup
    {
        private const string PathToFileToRead = @"../../students.txt";
        private static char[] separators =  new [] {' ', '|'};

        public static void Main()
        {
            var sortedStudentCourses = new SortedDictionary<string, SortedDictionary<string, string>>();
            StreamReader file = new StreamReader(PathToFileToRead);
            string line = string.Empty;
            while ((line = file.ReadLine()) != null)
            {
                var lineSplited = line.Split(separators, StringSplitOptions.RemoveEmptyEntries);
                string firstName = lineSplited[0];
                string lastName = lineSplited[1];
                string language = lineSplited[2];
                if (!sortedStudentCourses.ContainsKey(language))
                {
                    sortedStudentCourses[language] = new SortedDictionary<string, string>();
                }

                sortedStudentCourses[language].Add(lastName, firstName);
            }

            foreach (var course in sortedStudentCourses)
            {
                Console.Write("{0}: ", course.Key);
                foreach (var student in course.Value)
                {
                    Console.Write("{0} {1}, ", student.Value, student.Key);
                }

                Console.WriteLine();
            }
        }
    }
}