// Write a program that prints an isosceles triangle of 9 copyright symbols ©.
//Use Windows Character Map to find the Unicode code of the © symbol.
// the © symbol may be displayed incorrectly.


using System;
using System.Text; 

class TheCopyrightSymbol
{
    static void Main()
    {
        char copyRight = '©';
        Console.OutputEncoding = Encoding.UTF8;
        Console.WriteLine(@"
    {0}
   {0} {0}
  {0}   {0}
 {0} {0} {0} {0}", copyRight);

    }
}
