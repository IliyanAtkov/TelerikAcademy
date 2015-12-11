using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTask.ViewModels
{
    public class Person
    {
        public Person(string name, string imageSrc)
        {
            this.Name = name;
            this.ImageSrc = imageSrc;
        }

        public string Name { get; set; }

        public string ImageSrc { get; set;}
    }
}
