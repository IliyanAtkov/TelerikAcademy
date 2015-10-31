// Write a program that reads two dates in the format: day.month.year and calculates 
// the number of days between them. Example:
// Enter the first date: 27.02.2006
// Enter the second date: 3.03.2004
// Distance: 4 days


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

class BetweenTwoDates
{
    static void DatetimeDistance()
    {
        string firstDate = "27.02.2006";
        string secondDate = "3.03.2006";

        DateTime startDate = DateTime.ParseExact(firstDate, "d.MM.yyyy", CultureInfo.InvariantCulture);
        DateTime endDate = DateTime.ParseExact(secondDate, "d.MM.yyyy", CultureInfo.InvariantCulture);

        Console.WriteLine((endDate - startDate).TotalDays);
    }
    static void Main()
    {
        DatetimeDistance();
    }
}

