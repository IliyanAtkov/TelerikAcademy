namespace Bank
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;


    public class MortgageAccount : Account, IDepositable
    {
        public MortgageAccount(Customer customer, decimal balance, decimal interestRate)
            : base(customer, balance, interestRate)
        {
        }



        public void Deposit(decimal amount)
        {
            if (amount < 0)
            {
                throw new ArgumentException("Amount cannot be negative");
            }
            Balance += amount;
        }

        public override decimal InterestAmountForPeriod(uint months)
        {
            if (this.Customer.GetType().ToString() == "Individual")
        {
            if (months <= 6)
            {
                return 0;
            }
            else
            {
                return (this.Balance * this.interestRate) * (months - 6);
            }
        }
        else
        {
            if (months <= 12)
            {
                return (this.Balance * (this.interestRate / 2)) * (months);
            }
            else
            {
                return (this.Balance * (this.interestRate / 2)) * (months) + (this.Balance * this.interestRate) * (months - 12);
            }
        }
    
        }
    }
}
