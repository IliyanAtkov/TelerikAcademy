using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

    class Program
    {
        static void Print(List<string> word, int bestLenth)
        {
            string fuckWords;
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < bestLenth; i++)
            {
                
                for (int j = 0; j < word.Count; j++)
                {
                    fuckWords = word[j];
                    char[] newChar = new char[fuckWords.Length];
                    newChar = fuckWords.ToCharArray();
                    if (fuckWords.Length > i)
                    {
                        sb.Append(newChar[i]);
                    }
                }
            }
            Console.WriteLine(sb);
        }
        static void ReOrder(List<string> word, int n, int bestLenght)
        {
            int index = 0;
            for (int i = 0; i <= n - 1; i++)
            {
                index = (word[i].Length) % (n + 1);
                string oneword = word[i];
                word.Insert(index, word[i]);
                if (oneword == word[i + 1])
                {
                    word.RemoveAt(i + 1);
                }
               else
                {
                    word.RemoveAt(i);
                }
            }

            Print(word, bestLenght);
        }
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int bestLenght = int.MinValue;
            List<string> word = new List<string>();
            if (n == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                
                for (int i = 0; i < n; i++)
                {
                    string oneWord = Console.ReadLine();

                    if (oneWord.Length > bestLenght)
                    {
                        bestLenght = oneWord.Length;
                    }
                    word.Add(oneWord);
                }
            }
            if (word.Count == 0)
            {
                Console.WriteLine(0);
            }
            ReOrder(word, n, bestLenght);
        }
    }
