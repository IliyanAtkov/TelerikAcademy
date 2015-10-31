using System;
using System.Threading;
using System.Globalization;


class CoffeMachine
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
        double n1 = double.Parse(Console.ReadLine());
        double n2 = double.Parse(Console.ReadLine());
        double n3 = double.Parse(Console.ReadLine());
        double n4 = double.Parse(Console.ReadLine());
        double n5 = double.Parse(Console.ReadLine());
        double A = double.Parse(Console.ReadLine());
        double P = double.Parse(Console.ReadLine());

        double tray = (n1 * 0.05) + (n2 * 0.10) + (n3 * 0.20) + (n4 * 0.50) + (n5 * 1.00);
        double change = A - P;
        double moneyinmachine = tray - change;

        if (P <= A && moneyinmachine > 0)
        {
            Console.WriteLine("Yes {0:0.00}", moneyinmachine);
        }
        else if (P > A && moneyinmachine > 0)
        {
            Console.WriteLine("More {0:0.00}", P - A);
        }
        else
        {
            Console.WriteLine("No {0:0.00}", Math.Abs(moneyinmachine));
        }
        
    }
}

