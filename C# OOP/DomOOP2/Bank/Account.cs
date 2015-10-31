namespace Bank
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public abstract class Account
    {
        public Customer Customer { get; private set; }
        public decimal Balance { get; protected set; }
        public decimal interestRate;

        protected Account(Customer customer, decimal balance, decimal interestRate)
        {
            this.Customer = customer;
            this.Balance = balance;
            this.InterestRate = interestRate;
        }

        public decimal InterestRate
        {
            get { return this.InterestRate; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Interest rate cannot be less than zero");
                }
                this.interestRate = value;
            }
        }
        public virtual decimal InterestAmountForPeriod(uint months)
        {
            return (this.Balance * this.interestRate) * months;
        }
    }

}
