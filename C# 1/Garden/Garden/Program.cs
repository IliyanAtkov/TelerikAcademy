using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class Program
{
    static void Main()
    {
        double tomatoSeed = double.Parse(Console.ReadLine());
        long tomatoArea = long.Parse(Console.ReadLine());
        double cucumberSeed = double.Parse(Console.ReadLine());
        long cucumberArea = long.Parse(Console.ReadLine());
        double potatoSeed = double.Parse(Console.ReadLine());
        long potatoArea = long.Parse(Console.ReadLine());
        double carrotSeed = double.Parse(Console.ReadLine());
        long carrotArea = long.Parse(Console.ReadLine());
        double cabbageSeed = double.Parse(Console.ReadLine());
        long cabbageArea = long.Parse(Console.ReadLine());
        double beanSeed = double.Parse(Console.ReadLine());
        long totalArea = 250;
        double priceSeed = 0;
        long area = 0;
        long remainderArea = 0;

        priceSeed += (tomatoSeed * 0.5) + (cucumberSeed * 0.4) + (potatoSeed * 0.25) + (carrotSeed * 0.6) + (cabbageSeed * 0.3) + (beanSeed * 0.4);
        
        area += tomatoArea + cucumberArea + potatoArea + carrotArea + cabbageArea;

        remainderArea = totalArea - area;

        Console.WriteLine("Total costs: {0:F2}", priceSeed);

        if (remainderArea > 0)
        {
            Console.WriteLine("Beans area: {0}", remainderArea);         
        }
        else if (remainderArea < 0)
        {
            Console.WriteLine("Insufficient area");
        }
        else if (remainderArea == 0)
        {
            Console.WriteLine("No area for beans");
        }
    }
}

