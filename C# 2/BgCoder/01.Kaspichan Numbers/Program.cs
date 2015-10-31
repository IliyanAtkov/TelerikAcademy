using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


    class Program
    {
        static void Main()
        {
            ulong number = ulong.Parse(Console.ReadLine());
            List<string> listche = new List<string>();
            string res = "";
            for (char i = 'A'; i <= 'Z'; i++)
            {
                listche.Add(i.ToString());
            }
            for (char i = 'a'; i <= 'z'; i++)
            {
                for (char k = 'A'; k <= 'Z'; k++)
                {
                    listche.Add(i.ToString() + k.ToString());
                }
            }
            if (number == 0)
            {
                Console.WriteLine('A');
            }
            else
            {
                while (number != 0)
                {
                    res = listche[(int)(number % 256)] + res;
                    number = number / 256;
                    
                }
                Console.WriteLine(res);
            }
            
            
        }
    }

