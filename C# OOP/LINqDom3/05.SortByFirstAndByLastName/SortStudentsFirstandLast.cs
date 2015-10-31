namespace SortByFirstAndByLastName
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;


    class SortStudentsFirstandLast
    {
        static void Main()
        {
            var students = new[]
            {
                new{firstname="Gosho", lastname="Toshev", age=18},
                new{firstname="Zara", lastname="Martinova", age=17},
                new{firstname="Petko", lastname="Valentinov", age=35},
                new{firstname="Stoil", lastname="Shtrausa", age=70},
                new{firstname="Kamen", lastname="Vodenicharov", age=23},
                new{firstname="Martina", lastname="Stoilova", age=22},
                new{firstname="Valio", lastname="Toploto", age=30},
                new{firstname="Adriana", lastname="Profesorova", age=22},
            };

            // with lambda expressions
            var studentsWithLambda = 
                students.OrderByDescending(st => st.firstname)
                .ThenByDescending(st => st.lastname);

            Console.WriteLine("With lambda");
            foreach (var student in studentsWithLambda)
            {
                Console.WriteLine(student);
            }

            
            //with linq
            var studentsWithLinq =
                from student in students
                orderby student.firstname descending, student.lastname descending
                select student;

            Console.WriteLine("\nWith linq");
            foreach (var student in studentsWithLinq)
            {
                Console.WriteLine(student);
            }


        }
    }
}
