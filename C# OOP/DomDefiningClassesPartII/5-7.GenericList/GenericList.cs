namespace Generic
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class GenericList<T> where T : IComparable<T>, IComparable
    {
        private T[] elements;
        private int counter { get; set; }

        public GenericList(int capacity)
        {
            this.elements = new T[capacity];
        }

        public T this[int index]
        {
            get
            {
                if (index >= counter || index < 0)
                {
                    throw new IndexOutOfRangeException("The index was not inside in array");
                }
                T endResult = elements[index];
                return endResult;
            }
        }

        public void Add(T element)
        {
            if (counter >= elements.Length)
            {
                DoubleSize();
            }
            elements[counter] = element;
            counter++;
        }

        public void DoubleSize()
        {
            T[] tempArray = new T[elements.Length * 2];
            Array.Copy(elements, tempArray, elements.Length);
            elements = tempArray;
        }

        public void RemoveAt(int index)
        {
            if (index < elements.Length && index >= 0)
            {


                T[] tempArray = new T[elements.Length - 1];
                for (int i = 0; i < index; i++)
                {
                    tempArray[i] = elements[i];
                }
                if (index != elements.Length - 1)
                {
                    for (int i = index + 1; i < tempArray.Length; i++)
                    {
                        tempArray[i - 1] = elements[i];
                    }
                }
                elements = tempArray;
                counter--;
            }
            else
            {
                Console.WriteLine("Index was outside boundaries of array");
            }
        }

        public void InsertAt(int index, T element)
        {
            T[] temparray = new T[elements.Length + 1];
            for (int i = 0; i < index; i++)
            {
                temparray[i] = elements[i];
            }
            temparray[index] = element;
            for (int i = index + 1; i < temparray.Length; i++)
            {
                temparray[i] = elements[i - 1];
            }
            elements = temparray;
            counter++;
        }

        public void Find(T value)
        {
            for (int i = 0; i < counter; i++)
            {
                if (elements[i].Equals(value))
                {
                    Console.WriteLine("The element {0} is at index {1}",elements[i], i);
                    return;
                }
            }
            Console.WriteLine("There is no such element");
        }
        public void Clear()
        {
            int length;
            length = elements.Length;
            elements = new T[length];
            counter = elements.Length;
        }

        public T Min()
        {
            dynamic min = elements[0];
            for (int i = 0; i < counter; i++)
            {
                T tempValue = (dynamic)this.elements[i];
                if (tempValue.CompareTo(min) < 0)
                {
                    min = elements[i];
                }
            }
            return min;
       
        }

        public T Max()
        {
            dynamic max = elements[0];
            for (int i = 0; i < counter; i++)
            {
                T tempValue = (dynamic)this.elements[i];
                if (tempValue.CompareTo(max) > 0)
                {
                    max = elements[i];
                }
            }
            return max;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var element in elements)
            {
                sb.Append(element + "  ");
            }
            string readyToPrint = sb.ToString();
            return readyToPrint;
        }
    }
}
