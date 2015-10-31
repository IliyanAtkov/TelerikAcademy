namespace Students
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Student
    {
        private string firstName;
        private string lastName;
        private string fn;
        private string phone;
        private string email;
        private List<int> marks;
        private int groupNumber;

        public Student(string firstName, string lastName, string fn, string phone, string email, int groupNumber, List<int> marks)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Fn = fn;
            this.Phone = phone;
            this.Email = email;
            this.GroupNumber = groupNumber;
            this.Marks = marks;
            
        }

        public string FirstName
        {
            get { return this.firstName; }
            set
            {
                if (value.Length == 0)
                {
                    throw new ArgumentException("The name cannot be null");
                }
                this.firstName = value;
            }
        }

        public string LastName
        {
            get { return this.lastName; }
            set
            {
                if (value.Length == 0)
                {
                    throw new ArgumentException("The name cannot be null");
                }
                this.lastName = value;
            }
        }

        public string Fn
        {
            get { return this.fn; }
            set
            {
                if (value.Length == 0)
                {
                    throw new ArgumentException("The fn cannot be null");
                }
                this.fn = value;
            }
        }

        public string Phone
        {
            get { return this.phone; }
            set
            {
                if (value.Length == 0)
                {
                    throw new ArgumentException("The phone cannot be null");
                }
                this.phone = value;
            }
        }

        public string Email
        {
            get { return this.email; }
            set
            {
                if (value.Length == 0)
                {
                    throw new ArgumentException("The email cannot be null");
                }
                this.email = value;
            }
        }

        public List<int> Marks
        {
            get { return this.marks; }
            set
            {
                if (value.Count == 0)
                {
                    throw new ArgumentException("The marks cannot be null");
                }
                this.marks = value;
            }
        }

        public int GroupNumber
        {
            get { return this.groupNumber; }
            set
            {
                if (value == 0)
                {
                    throw new ArgumentException("The group number cannot be zero");
                }
                this.groupNumber = value;
            }
        }

        public void AddMark(int mark)
        {
            if (mark >= 2 && mark <= 6)
            {
                this.marks.Add(mark);
            }
            else
            {
                throw new ArgumentException("There is no such mark");
            }
        }

        public void RemoveMarkAt(int position)
        {
            if (position >= 0 && position < marks.Count)
            {
                Marks.RemoveAt(position);
            }
            else
            {
                throw new IndexOutOfRangeException("Index out of range");
            }
        }

        public bool ContainThatMark(int mark)
        {
            if (mark >= 2 && mark <= 6)
            {
              return marks.Contains(mark);
            }
            else
            {
                throw new ArgumentException("There is no such mark");
            }
        }

        public string GetMarks()
        {
            return string.Join(", ", this.marks);
        }

        public override string ToString()
        {
            return string.Format("First Name: " + this.firstName + "\n Last Name: " + this.lastName
                + "\nfn: " + this.fn + "\nphone: " + this.phone + "\nemail: "
                + this.email + "\ngroup number: " + this.groupNumber);
        }

        
    }
}
