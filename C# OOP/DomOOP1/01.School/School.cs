namespace School
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;


    public class School
    {
        private string name;
        private List<Classes> classes;

        public School(string name, List<Classes> classes)
        {
            this.name = name;
            this.classes = new List<Classes>();
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Scholl name cannot be null");
                }
                this.name = value;
            }
        }
    }
}
