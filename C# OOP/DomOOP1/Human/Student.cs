namespace Human
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;


    public class Student : Human
    {
        public uint grade { get; private set; }

        public Student(string firstName, string lastName, uint grade)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.grade = grade;
        }
    }


}
