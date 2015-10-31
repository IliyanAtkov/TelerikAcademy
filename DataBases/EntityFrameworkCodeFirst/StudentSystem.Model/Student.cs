namespace StudentSystem.Model
{
    using System.Collections.Generic;

    public class Student
    {
        private ICollection<Homework> homeworks;

        public Student()
        {
            this.homeworks = new HashSet<Homework>();
        }

        public int StudentID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int StudentNumber { get; set; }

        public ICollection<Homework> Homeworks
        {
            get {  return this.homeworks; }
            set { this.homeworks = value; }
            
        }
    }
}
