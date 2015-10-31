using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace School
{
    public class Student
    {
        private string name;

        private int uniqueId;

        public Student(string name, int uniqueId)
        {
            this.Name = name;
            this.UniqueId = uniqueId;
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
                    throw new ArgumentNullException("Student Name cannot be Null or Zero lenght");
                }

                this.name = value;
            }
        }

        public int UniqueId
        {
            get
            {
                return this.uniqueId;
            }
            set
            {
                bool isvalueInRange = value >= 10000 && value <= 99999;
                if (isvalueInRange)
                {
                    this.uniqueId = value;
                }
                else
                {
                    throw new ArgumentException("Unique ID should be between 10000 and 99999");
                }
            }
        }
    }
}
