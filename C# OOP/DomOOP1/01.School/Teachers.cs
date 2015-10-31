namespace School
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Teachers : People, IComment
    {
        public List<Disciplines> disciplines { get; set; }
        public string FreeText { get; set; }

        public Teachers(string name, string freeText)
        {
            this.Name = name;
            this.disciplines = new List<Disciplines>();
            this.FreeText = freeText;
        }
        public Teachers(string name)
            : this(name,  null)
        {
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(this.Name);
            sb.Append(" Disciplines - ");
            foreach (var item in disciplines)
            {
                sb.Append(item + "; ");
            }
            sb.Remove(sb.Length - 2, 2);
            return sb.ToString();
        }
        
    }
}
