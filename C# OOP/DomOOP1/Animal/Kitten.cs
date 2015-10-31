namespace Animal
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Kitten : Cat
    {
        public Kitten(uint age, string name)
            : base(age, name, 'f')
        {
        }
    }

}
