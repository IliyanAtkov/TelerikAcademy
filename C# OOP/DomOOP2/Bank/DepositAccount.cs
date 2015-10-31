namespace Bank
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class DepositAccount : Account, IDepositable, IWithDrawable
    {
        public DepositAccount(Customer customer, decimal balance, decimal interestRate)
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

        public void WithDraw(decimal amount)
        {
            if (amount > Balance || amount < 0)
            {
                throw new ArgumentException("Amount is bigger than balance, or amount is negative");
            }
            Balance -= amount;
        }

        public override decimal InterestAmountForPeriod(uint months)
        {
            if (this.Balance <= 1000 && this.Balance >= 0)
            {
                return 0;
            }
            else
            {
                return base.InterestAmountForPeriod(months);
            }

        }
    }
}
