namespace Bank
{
    using System;

    class Program
    {
        static void Main()
        {
            Account[] accounts =
            {
                new DepositAccount(new Individual("Pesho"), 1500, 15),
                new MortgageAccount(new Individual("Ganio"), 2000, 5),
                new LoanAccount(new Company("Tanio"), 2500, 100),
                new DepositAccount(new Company("Kuci"), 1000, 35),
            };
        }
    }
}
