// Define a class that holds information about a mobile phone device:
// model, manufacturer, price, owner, battery characteristics 
// (model, hours idle and hours talk) and display characteristics (size and number of colors).
// Define 3 separate classes (class GSM holding instances of the classes Battery and Display).

using System;

public class Program
{
    static void Main()
    {
       GSM gsm = new GSM("Vanio", "Tanio");
       GSMTest test = new GSMTest();
       string[] models = { "Nokia", "Samsung", "Motorola" };
       string[] manafacturer = { "China", "Belarus", "Russia" };
       int[] prices = { 300, 500, 2000 }; 
       string[] owner = { "Gosho", "Pesho", "Vasko" };
      Console.Write(test.GsmTestInformation(models, manafacturer, prices, owner));
      Console.WriteLine(GSM.IPhone4S);
      GSMCallHistoryTest phone = new GSMCallHistoryTest();
      phone.AddTestCalls(gsm);
      gsm.PrintCalls();
      Console.Write("The total price is: ");
      Console.WriteLine(gsm.CalculatePrice(0.37m));
      phone.RemoveBiggestCall(gsm);
      Console.Write("The price after removing bigest talk: ");
      Console.WriteLine(gsm.CalculatePrice(0.37m));
      gsm.ClearCalls();
    }
}