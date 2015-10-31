namespace School
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;


    public class Classes : IComment
    {
        public List<Students> students { get; set;}
        public List<Teachers> teachers { get; set; }
        private string ClassId { get; set; }
        public string FreeText { get; set; }

        public Classes(string classID, string freeText)
        {
            this.students = new List<Students>();
            this.teachers = new List<Teachers>();
            this.ClassId = classID;
            this.FreeText = freeText;
        }

        public Classes(string classID)
            : this(classID, null)
        {
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(String.Format("Class '{0}'", ClassId));
            sb.Append("\nSet of students:\n");
            foreach (var item in students)
            {
                sb.Append(item + ";\n");
            }
            sb.Remove(sb.Length - 3, 3);
            sb.Append("\nSet of teachers:\n");
            foreach (var item in teachers)
            {
                sb.Append(item + ";\n");
            }
            sb.Remove(sb.Length - 3, 3);
            return sb.ToString();
        }

       
       
    }
}
