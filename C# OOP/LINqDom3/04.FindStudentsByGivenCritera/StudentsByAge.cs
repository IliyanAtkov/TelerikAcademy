namespace FindStudentsByGivenCritera
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;


    public class StudentsByAge
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

            var wantStudents =
                from student in students
                where student.age >= 18
                where student.age <= 23
                select student;

            foreach (var student in wantStudents)
            {
                Console.WriteLine(student);
            }
        }
    }
}
