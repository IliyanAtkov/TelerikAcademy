namespace InvalidException
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;


    
    public class InvalidRangeException<T> : ApplicationException
    {
        public T Start { get; set; }
        public T End { get; set; }
        public InvalidRangeException(string message, T start, T end)
            : base(message)
        {
            this.Start = start;
            this.End = end;
        }
    }
    
}
