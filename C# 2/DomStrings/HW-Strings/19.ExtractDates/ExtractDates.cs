// Write a program that extracts from a given text all dates that match the
// format DD.MM.YYYY. Display them in the standard date format for Canada.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Globalization;

class ExtractDates
{
    static void AllDatesExtract()
    {
        string text = "This is text 23.23.2012, but this is something other 28.12.2006, 12.03.2012";
        DateTime date;
        foreach (Match item in Regex.Matches(text, @"\b\d{2}.\d{2}.\d{4}\b"))
            if (DateTime.TryParseExact(item.Value, "dd.MM.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out date))
                Console.WriteLine(date.ToString(CultureInfo.GetCultureInfo("en-CA").DateTimeFormat.ShortDatePattern));
    }
    static void Main()
    {
        AllDatesExtract();
    }
}

