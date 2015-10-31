namespace School
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;


    public class Disciplines : IComment
    {
        private string name;
        public uint numberOfLectures { get; set; }
        public uint numberOfExercises { get; set; }
        public string FreeText { get; set; }

        public Disciplines(string name, uint numberOfLectures, uint numberOfExercises, string freeText)
        {
            this.Name = name;
            this.numberOfLectures = numberOfLectures;
            this.numberOfExercises = numberOfExercises;
            this.FreeText = freeText;
        }
        public Disciplines(string name, uint numberOfLectures, uint numberOfExercises)
            : this(name, numberOfLectures, numberOfExercises, null)
        {
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name cannot be null");
                }
                this.name = value;
            }
        }

        public override string ToString()
        {
            return String.Format("{0} - L{1}, E{2}", this.Name, this.numberOfLectures, this.numberOfExercises);
        }
    }
}
