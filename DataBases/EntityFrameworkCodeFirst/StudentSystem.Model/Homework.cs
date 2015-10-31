namespace StudentSystem.Model
{
    using System;

   public class Homework
    {
       public int HomeworkID { get; set; }

       public string Content { get; set; }

       public DateTime TimeSent { get; set; }

       public int StudentID { get; set; }

       public virtual Student Student { get; set; }

       public int CourseID { get; set; }

       public virtual Course Course { get; set; }
    }
}
