namespace StudentsAlphabetically
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Student
    {
        static void Main()
        {
            var students = new[]
            {
                new{firstname="Gosho", lastname="Toshev"},
                new{firstname="Zara", lastname="Martinova"},
                new{firstname="Petko", lastname="Valentinov"},
                new{firstname="Stoil", lastname="Shtrausa"},
                new{firstname="Kamen", lastname="Vodenicharov"},
                new{firstname="Martina", lastname="Stoilova"},
                new{firstname="Valio", lastname="Toploto"},
                new{firstname="Adriana", lastname="Profesorova"},
            };

            var wantStudents =
                from student in students
                where student.firstname.CompareTo(student.lastname) == -1
                select student;

            foreach (var student in wantStudents)
            {
                Console.WriteLine(student);
            }
        }
    }
}
