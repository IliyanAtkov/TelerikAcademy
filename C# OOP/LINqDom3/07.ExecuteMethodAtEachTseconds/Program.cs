namespace ExecuteMethodAtEachTseconds
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    class Program
    {
        static void Main()
        {
            Timer tm = new Timer();
            tm.Beggining(Console.WriteLine, 5, 3);
        }
    }
}
