using System;
using Kitchen;

public class Refactor
{
    public static void Main()
    {
        // task 2
        int x = 0;
        int y = 0;
        int minX = 0;
        int maxX = 0;
        int maxY = 0;
        int minY = 0;
        bool shoudVisitCell = true;
        bool isYBetweemMinMax = minY <= y && y <= maxY;
        bool isXBetweenMinMax = minX <= x && x <= maxX;
        if (isXBetweenMinMax && (isYBetweemMinMax && shoudVisitCell))
        {
            VisitCell();
        }

        // task 1
        Potato potato = new Potato();
        if (potato != null)
        {
            if (potato.IsPeeled && potato.IsRotten)
            {
                Cook(potato);
            }
        }
    }

    private static void Cook(Potato potato)
    {
        Console.WriteLine("Cooking");
    }

    private static void VisitCell()
    {
        Console.WriteLine("Visiting the cell");
    }
}
