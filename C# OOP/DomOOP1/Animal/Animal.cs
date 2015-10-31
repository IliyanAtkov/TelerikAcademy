namespace Animal
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;


    public class Animal
    {
        public uint Age { get; private set; }
        private string name;
        private char sex;

        public Animal(uint age, string name, char sex)
        {
            this.Age = age;
            this.Name = name;
            this.Sex = sex;
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

        public char Sex
        {
            get { return this.sex; }
            set
            {
                this.sex = value;
            }
        }

        public void IdentifyAnimal()
        {
            Console.WriteLine("I am " + GetType().Name);
        }

        public static double Average(Animal[] array)
        {
            double total = 0;
            for (int i = 0; i < array.Length; i++)
            {
                total = total + array[i].Age;
            }
            return total / array.Length;
        }

 
        
    }
}
