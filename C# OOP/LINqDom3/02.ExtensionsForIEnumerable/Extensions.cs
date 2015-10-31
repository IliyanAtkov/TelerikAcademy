namespace ExtensionsForIEnumerable
{
    using System;
    using System.Text;
    using System.Collections.Generic;
    using System.Linq;

    public static class Extensions
    {
        public static decimal Sum<T>(this IEnumerable<T> enumerations) where T : IComparable, IFormattable,
            IConvertible,IComparable<T>,IEquatable<T>
        {
            decimal sum = 0;
            if (enumerations.Count() == 0)
            {
                throw new ArgumentException("There is no elements");
            }

            foreach (var enumeration in enumerations)
            {
                sum += Convert.ToDecimal(enumeration);
            }

            return sum;
        }

        public static decimal Max<T>(this IEnumerable<T> enumerations) where T : IComparable, IFormattable,
            IConvertible, IComparable<T>, IEquatable<T>
        {
            if (enumerations.Count() == 0)
            {
                throw new ArgumentException("There is no elements");
            }

            decimal max = decimal.MinValue;
            decimal temp = 0;
            foreach (var enumeration in enumerations)
            {
                temp = Convert.ToDecimal(enumeration);
                if (temp > max)
                {
                    max = temp;
                }
            }

            return max;
        }

        public static decimal Min<T>(this IEnumerable<T> enumerations) where T : IComparable, IFormattable,
            IConvertible, IComparable<T>, IEquatable<T>
        {
            if (enumerations.Count() == 0)
            {
                throw new ArgumentException("There is no elements");
            }

            decimal min = decimal.MaxValue;
            decimal temp = 0;
            foreach (var enumeration in enumerations)
            {
                temp = Convert.ToDecimal(enumeration);
                if (temp < min)
                {
                    min = temp;
                }
            }
            return min;
        }

        public static decimal Average<T>(this IEnumerable<T> enumerations) where T : IComparable, IFormattable,
            IConvertible, IComparable<T>, IEquatable<T>
        {
            if (enumerations.Count() == 0)
            {
                throw new ArgumentException("There is no elements");
            }

            decimal average = 0;
            decimal temp = 0;
            foreach (var enumeration in enumerations)
            {
               temp = Convert.ToDecimal(enumeration);
               average += temp;
            }
            return average / enumerations.Count();
        }

        public static decimal Product<T>(this IEnumerable<T> enumerations) where T : IComparable, IFormattable,
            IConvertible, IComparable<T>, IEquatable<T>
        {
            if (enumerations.Count() == 0)
            {
                throw new ArgumentException("There is no elements");
            }

            decimal product = 1;
            decimal temp = 0;

            foreach (var enumeration in enumerations)
            {
                temp = Convert.ToDecimal(enumeration);
                product *= temp;
            }
            return product;
        }
    }
}
