namespace ExecuteMethodAtEachTseconds
{
    using System;
    using System.Threading;


    public delegate void DelegateExample();
    

    public class Timer
    {
        public void Beggining(DelegateExample someMethod, int intervalInSeconds, int totalTime)
        {
            DateTime begin = DateTime.Now;
            DateTime end = begin.AddSeconds(totalTime);

            while (begin <= end)
            {
                Console.WriteLine("Text will repeat a few seconds");
                Thread.Sleep(intervalInSeconds);
                begin = DateTime.Now;

            }

        }
        
    }
}
