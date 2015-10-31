namespace Human
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            List<Student> students = new List<Student>()
            {
                new Student("Pesho", "Trakiev", 12),
                new Student("Vasko", "Keca", 11),
                new Student("Joro", "Iliev", 5),
                new Student("Gaco", "Mirkata", 11),
                new Student("Valio", "Toploto", 8),
                new Student("Boiko", "Borisov", 10),
                new Student("Evgeni", "Minchev", 3),
                new Student("Todor", "Georgiev", 4),
                new Student("Iliqn", "Peshov", 5),
                new Student("Nasko", "Rumbev", 11),
            };

            var sortedStudentsByGrade =
                from student in students
                orderby student.grade ascending
                select student;

            Console.WriteLine("Students sorted: ");
            foreach (var student in sortedStudentsByGrade)
            {
                
                Console.WriteLine("Name: {0} {1}  Grade:{2}",student.FirstName, student.LastName, student.grade);
            }
            Console.WriteLine();
            Console.WriteLine();

            List<Worker> workers = new List<Worker>()
            {
                new Worker("Kiro","Vasilev", 350, 4m),
                new Worker("Traicho","Ivanov",220.25m, 8.5m),
                new Worker("Iliqn","Stoqnov",123.5m,4m),
                new Worker("Joro","Petrov",300m,3m),
                new Worker("Ganko","Malkiq",400m,4m),
                new Worker("Lubcho","Trakieca",390m,6m),
                new Worker("Drago","Mechkata",99m,7m),
                new Worker("Toni","Gargarov",3000m,8m),
                new Worker("Moni","Trakieva",400.35m,9m),
                new Worker("Vili","Ivanova",125.5m,11m),
            };

            var sortedWorkersBySalaryPerHour =
                from worker in workers
                orderby worker.MoneyPerHour() descending
                select worker;

            Console.WriteLine("Workers sorted: ");
            foreach (var worker in sortedWorkersBySalaryPerHour)
            {
                Console.WriteLine("Name: {0} {1}    Money per Hour: {2:c}", worker.FirstName, worker.LastName, worker.MoneyPerHour());
            }

            List<Human> mergedList = new List<Human>();
            mergedList.AddRange(sortedStudentsByGrade);
            mergedList.AddRange(sortedWorkersBySalaryPerHour);
            var allSorted =
                from sorted in mergedList
                orderby sorted.FirstName, sorted.LastName
                select sorted;

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("All sorted by first and last name: ");
            foreach (var sorted in allSorted)
            {
                Console.WriteLine("{0} {1}",sorted.FirstName, sorted.LastName);
            }
            
        }

    }
}
