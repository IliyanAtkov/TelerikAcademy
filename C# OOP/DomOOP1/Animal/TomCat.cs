
namespace Animal
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;


    public class TomCat : Cat
    {
        public TomCat(uint age, string name)
            : base(age, name, 'm')
        {
        }
    }
}
