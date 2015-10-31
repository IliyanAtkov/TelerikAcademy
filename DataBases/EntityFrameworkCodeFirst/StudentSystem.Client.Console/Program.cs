namespace StudentSystem.Client.Console
{
    using StudentSystem.Data;
    using StudentSystem.Model;
    using System.Data.Entity;
    using StudentSystem.Data.Migrations;
    public class Program
    {
        static void Main()
        {
            
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<StudentSystemContext, Configuration>());
            var db = new StudentSystemContext();
          
            using (db)
            {
                var homework = new Homework();
                var student = new Student();
                var course = new Course();

                student.FirstName = "Gancho";
                student.LastName = "Minchev";
                student.StudentNumber = 12345;

                course.Name = "Animals";
                course.Students.Add(student);
                course.Homeworks.Add(homework);
                course.Materials = "Books";
                course.Students.Add(student);
                
                homework.Content = "African Animals";
                homework.Course = course;
                student.Homeworks.Add(homework);


                db.SaveChanges();
            }
        }
    }
}
