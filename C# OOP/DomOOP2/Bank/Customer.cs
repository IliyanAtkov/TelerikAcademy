namespace Bank
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;


    public class Customer
    {
        public string Name { get; set; }

        public Customer(string name)
        {
            this.Name = name;
        }
    }
}
