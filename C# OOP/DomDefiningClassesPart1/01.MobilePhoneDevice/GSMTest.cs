using System;
using System.Text;

public class GSMTest
{
    public StringBuilder GsmOutput = new StringBuilder();
   
    public string GsmTestInformation(string[] testModels, string[] testManufacturer, int[] testPrice, string[] testOwner)
    {
        GSM[] gsmTest = new GSM[3];
        string[] models = testModels;
        string[] manafacturer = testManufacturer;
        int[] prices = testPrice;
        string[] owner = testOwner;
        for (int i = 0; i < gsmTest.Length; i++)
        { 
            gsmTest[i] = new GSM(models[i], manafacturer[i], prices[i], owner[i]);
            GsmOutput.Append(gsmTest[i] + "\n\r");
        }

        return GsmOutput.ToString();
    }   
}