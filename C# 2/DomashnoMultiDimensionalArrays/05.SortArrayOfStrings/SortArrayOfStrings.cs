// You are given an array of strings. Write a method that sorts the array
// by the length of its elements (the number of characters composing them).


using System;
using System.Collections.Generic;
using System.Linq;

class SortArrayOfStrings
{
    static void Main()
    {
        
	string[] array  =
	{
	    "KolumbiecOtQmaika",
	    "Kitaec",
	    "Bulgaria",
	    "KotkaVurhuPokriv",
	    "Bira",
	    "Hiena"
	};
	// Send the array to the method.
	foreach (string s in SortByLength(array))
	{
	    Console.WriteLine(s);
	}
    }

    static IEnumerable<string> SortByLength(IEnumerable<string> e)
    {
	// Use LINQ to sort the array received and return a copy.
	        var sorted = from s in e
		        orderby s.Length ascending
		        select s;
	        return sorted;
    }
    }


