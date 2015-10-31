namespace Human
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;


    public abstract class Human
    {
        private string firstName;
        private string lastName;

        public string FirstName
        {
            get { return this.firstName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name cannot be null");
                }
                if (value.Length <= 2)
                {
                    throw new ArgumentException("Name cannot be less than 2 symbols");
                }
                this.firstName = value;
            }
        }

        public string LastName
        {
            get { return this.lastName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name cannot be null");
                }
                if (value.Length <= 2)
                {
                    throw new ArgumentException("Name cannot be less than 2 symbols");
                }
                this.lastName = value;
            }
        }
    }
}
