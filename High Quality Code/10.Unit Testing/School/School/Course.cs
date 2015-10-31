using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace School
{
    public class Course
    {
        public const int MaxStudentsInTheCourse = 29;

        private List<Student> students;

        private string name;

        public Course(string name, IList<Student> students = null)
        {
            this.Students = new List<Student>();
            this.Name = name;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (value == null || value.Length == 0)
                {
                    throw new ArgumentNullException("Course Name cannot be Null or Zero lenght");
                }

                this.name = value;
            }
        }

        public List<Student> Students
        {
            get
            {
                return new List<Student>(students);
            }
            set
            {
                if (value == null || value.Count == 0)
                {
                    throw new ArgumentNullException("Students list cannot be null or empty");
                }

                this.students = value;
            }
        }

        public void AddStudent(Student student)
        {
            bool isStudentAlreadyExists = CheckIfStudentIsFound(student);
            if (isStudentAlreadyExists)
            {
                throw new ArgumentException("This student is already added");
            }
            else if (this.Students.Count + 1 <= MaxStudentsInTheCourse)
            {
                this.Students.Add(student);
            }
            else
            {
                throw new ArgumentException("The course is already full");
            }
        }

        public void RemoveStudent(Student student)
        {
            bool isStudentFound = CheckIfStudentIsFound(student);
            if (isStudentFound)
            {
                this.Students.Remove(student);
            }
            else
            {
                throw new ArgumentException("This student doesn't exist in the course");
            }
        }

        private bool CheckIfStudentIsFound(Student student)
        {
            bool found = false;
            for (int i = 0; i < this.Students.Count; i++)
            {
                if (this.Students[i].UniqueId == student.UniqueId)
                {
                    found = true;
                }
            }

            return found;
        }
    }
}
