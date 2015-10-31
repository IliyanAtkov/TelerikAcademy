// Write a program that reads a date and time given in
// the format: day.month.year hour:minute:second and prints the date and 
// time after 6 hours and 30 minutes (in the same format) along with the day of week in Bulgarian.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

class PrintTheDateAfter6HoursAnd30Minutes
{
    static void DateAfter()
    {
        Console.WriteLine("Enter date dd.mm.yyyy HH.mm.ss : ");
        string date = Console.ReadLine();
        DateTime dateEnter = DateTime.ParseExact(date, "dd.MM.yyyy HH:mm:ss", CultureInfo.InvariantCulture);
        dateEnter = dateEnter.AddHours(6.5);

        Console.WriteLine("{0} {1}", dateEnter.ToString("dddd", new CultureInfo("bg-BG")), dateEnter);
    }

    static void Main()
    {
        DateAfter();
    }
}

