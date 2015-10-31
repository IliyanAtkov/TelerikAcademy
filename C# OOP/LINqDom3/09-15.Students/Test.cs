namespace Students
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Test
    {
        public static List<Student> students = new List<Student>()
        {
            new Student("Shakiro", "Fudjimoti", "123406", "012/7600000","siso@abv.bg", 2, new List<int>(){2,3,4,5,3,4}),
            new Student("Pesho", "Peshkira", "923107", "02/43216","pesho@gmail.com", 3, new List<int>(){6,3,4,5,3,4}),
            new Student("Gosho", "Markucha", "184509", "02/03517","gosho@abv.bg", 3, new List<int>(){2,3,4,4,3,4}),
            new Student("Joro", "Traktora", "135406", "03/7612345","joro@gmail.com", 4, new List<int>(){3,3,4,2,2,4}),
            new Student("Bai", "Ganio", "999910", "08/7699999","bai@abv.bg", 6, new List<int>(){5,3,4,5,3,4}),
            new Student("Traiko", "Raichev", "888806", "02/7688888","traiko@gmail.com", 2, new List<int>(){6,4,4,4,3,4}),
            new Student("Georgi", "Dimitrov", "777705", "087/66677777","georgi@gmail.com", 1, new List<int>(){5,3,4,5,3,4}),
            new Student("Vasil", "Zueka", "666604", "02/7666666", "vasil@gmail.com",5, new List<int>(){3,3,4,5,3,4}),
            new Student("Dimitur", "Rachkov", "555506", "087/655555","dimitur@abv.bg", 6, new List<int>(){6,6,6,6,5,5}),
            new Student("Angeliq", "Stoimenova", "444403", "08/7644444","angeliq@agmail.com", 7, new List<int>(){4,4,4,4,3,4}),
            new Student("Diana", "Petrova", "333311", "08/7633333","diana@gmail.com", 2, new List<int>(){5,3,4,5,6,2}),
            new Student("Velizara", "Gradinarova", "222201", "05/7622222","velizara@agmail.com", 3, new List<int>(){5,3,4,5,3,4}),
            new Student("Valio", "Studenoto", "111101", "02/7611111","valio@gmail.com", 2, new List<int>(){5,3,4,5,3,4}),
            new Student("Gosho", "Krivoto", "364109", "08/612345", "gosho@gmail.com",1, new List<int>(){3,3,4,5,3,4}),
            new Student("Mariq", "Dulgucha", "245607", "03/7654321","mariq@gmail.com", 8, new List<int>(){4,4,4,5,3,4}),
        };

       
        public static void GroupNumberTwoLinqOrder(List<Student> students)
        {
            var result =
                from student in students
                where student.GroupNumber == 2
                orderby student.FirstName
                select student;

           // Print(result);
        }

        public static void EmailsInAbv(List<Student> students)
        {
            var result =
                from student in students
                where student.Email.Contains("@abv.bg")
                select student;

          //  Print(result);
        }

        public static void PhonesInSofia(List<Student> students)
        {
            var result =
                from student in students
                where student.Phone.Contains("02/")
                select student;

          //  Print(result);
        }

        public static void FindStudentsWithAtLeastOneExcellentMark(List<Student> students)
        {
            var result =
                from student in students
                where student.ContainThatMark(6)
                select new { FullName = student.FirstName + " " + student.LastName, Marks = student.GetMarks() };

         //  foreach (var student in result)
         //  {
         //      Console.WriteLine("{0} -> {1}", student.FullName, student.Marks);
         //  }
        }

        static void FindStudentsWithExactlyTwoMarks2(List<Student> students)
        {
            const int markToFind = 2;
            const int markAppearences = 2;

            var result =
                from student in students
                where student.Marks.Count(x => x == markToFind) == markAppearences
                select new { FullName = student.FirstName + " " + student.LastName, Marks = student.GetMarks() };
          //  foreach (var student in result)
          //  {
          //      Console.WriteLine("{0} -> {1}", student.FullName, student.Marks);
          //  }
          //  Console.WriteLine();
        }

        static void FindStudentMarksEnrolledIn2006(List<Student> students)
        {
            var result =
                from student in students
                where student.Fn.Substring(4, 2) == "06"
                select new { FullName = student.FirstName + " " + student.LastName, Fn = student.Fn, Marks = student.GetMarks() };

            foreach (var student in result)
            {
                Console.WriteLine("{0} - FN: {1} -> {2}", student.FullName, student.Fn, student.Marks);
            }
            Console.WriteLine();
        }

        static void Main()
        {
            // 09. Select only the students that are from group number 2. Use LINQ query. Order the students by FirstName.
            GroupNumberTwoLinqOrder(students);
            // 10. Implement the previous using the same query expressed with extension methods.
            students.GroupNumberTwoLinqOrderExtensionMethod();
            // 11.Extract all students that have email in abv.bg. Use string methods and LINQ.
            EmailsInAbv(students);
            // 12. Extract all students with phones in Sofia. Use LINQ.
            PhonesInSofia(students);
            // 13. Select all students that have at least one mark Excellent (6) into a new anonymous class that has properties – FullName and Marks. Use LINQ.
            FindStudentsWithAtLeastOneExcellentMark(students);
            // 14. Write down a similar program that extracts the students with exactly  two marks "2". Use extension methods.
            FindStudentsWithExactlyTwoMarks2(students);
            // 15. Extract all Marks of the students that enrolled in 2006. (The students from 2006 have 06 as their 5-th and 6-th digit in the FN).
            FindStudentMarksEnrolledIn2006(students);
        }

        public static void Print(IEnumerable<Student> students)
        {
            foreach (var student in students)
            {
                Console.WriteLine(student);
                Console.WriteLine();
            }
        }

    }
}
