//rite a method that reverses the digits of given decimal number. Example: 256  652

using System;

 public class ReverseNumber
{
    static void Main()
    {
        Reverse();
    }

    public static void Reverse()
    {
        string enteredNumber = Console.ReadLine();
        char[] number = enteredNumber.ToCharArray();

        if (number[0]=='-')
        {
            number[0]=' ';
        }
        Array.Reverse(number);
        string result = String.Join("",number);
        decimal decimalResult = decimal.Parse(result);
        Console.WriteLine(decimalResult);
    }
 
   
}

