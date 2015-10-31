namespace InvalidException
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    class Program
    {
        static void Main()
        {

            DateTime t = DateTime.Now;
            InvalidRangeException<int> intException =
                new InvalidRangeException<int>("Number in rage 1-100!", 1, 100);
            Console.WriteLine("Enter 3 numbers from 1 do 100:");
            for (int i = 0; i < 3; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (number < intException.Start || number > intException.End)
                {
                    throw intException;
                }
                else
                {
                    Console.WriteLine("correct!");
                }
            }
            string startDate = "1/1/1980";
            string endDate = "1/1/2013";

            InvalidRangeException<DateTime> DateExcepction =
                new InvalidRangeException<DateTime>("Date in range 1980-2013"
                    , DateTime.Parse(startDate), DateTime.Parse(endDate));
            Console.WriteLine("Enter 3 dates in the  format: dd.mm.yyyy!(from 1980 to 2013)");
            for (int i = 0; i < 3; i++)
            {
                string date = Console.ReadLine();
                DateTime TheDate = DateTime.Parse(date);
                if (TheDate.Year < DateExcepction.Start.Year || TheDate.Year > DateExcepction.End.Year)
                {
                    throw DateExcepction;
                }
                else
                {
                    Console.WriteLine("correct!");
                }
            }
        }

    }
}
