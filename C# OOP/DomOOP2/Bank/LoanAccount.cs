namespace Bank
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;


    public class LoanAccount : Account, IDepositable
    {
        public LoanAccount(Customer customer, decimal balance, decimal interestRate)
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
            if (this.Customer.GetType().ToString()=="Individual")
            {
                if (months<=3)
                {
                    return 0;
                }
                else
                {
                    return (this.Balance * this.interestRate) * (months - 3);
                }
            }
            else
            {
                if (months<=2)
                {
                    return 0;
                }
                else
                {
                    return (this.Balance * this.interestRate) * (months - 2);
                }
        }
        }
    }

}
