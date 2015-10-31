namespace StudentSystem.Data
{
    using System.Data.Entity;
    using StudentSystem.Model;
    public class StudentSystemContext : DbContext
    {
        public StudentSystemContext() 
            : base("StudentSystemDB")
        {

        }
        public DbSet<Course> Courses { get; set; }

        public DbSet<Homework> Homeworks { get; set; }

        public DbSet<Student> Students { get; set; }
    }
}
