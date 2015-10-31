namespace School
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;


    public class Students : People, IComment
    {
        private string classNumber;
        public string FreeText { get; set; }

        public Students(string name, string classNumber, string freeText)
        {
            this.Name = name;
            this.ClassNumber = classNumber;
            this.FreeText = freeText;
        }
        public Students(string name, string classNumber)
            : this(name, classNumber, null)
        {
        }
       
        public string ClassNumber
        {
            get { return this.classNumber; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Class number cannot be null");                  
                }
                this.classNumber = value;
            }
        }
        public override string ToString()
        {
            return String.Format("{0} - ID {1}", this.Name, this.classNumber);
        }
    }
}
