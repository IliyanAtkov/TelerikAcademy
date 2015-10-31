// Write a program that reads a text file containing a list of strings,
// sorts them and saves them to another text file. Example:
//	Ivan			George
//	Peter			Ivan
//	Maria			Maria
//	George			Peter


using System;
using System.IO;
using System.Collections.Generic;

class SortNames
{
    static void Main()
    {
        using (StreamReader reader = new StreamReader("names.txt"))
        {
            List<string> names = new List<string>();

            for (string nameInTheMoment = reader.ReadLine(); nameInTheMoment != null; nameInTheMoment = reader.ReadLine())
            {
                names.Add(nameInTheMoment);
            }

            names.Sort();

            using (StreamWriter writer = new StreamWriter("sortedNames.txt"))
            {
                foreach (var name in names)
                {
                    writer.WriteLine(name);
                }
            }
        }
    }

}