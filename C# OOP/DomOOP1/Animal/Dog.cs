namespace Animal
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;


    public class Dog : Animal, ISound
    {
        public Dog(uint age, string name, char sex)
            : base(age, name, sex)
        {
        }

        public void ProduceSound()
        {
            Console.WriteLine(Name + " bau");
        }
    }
}
