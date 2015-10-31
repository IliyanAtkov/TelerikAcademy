using System;


public class Display
{
    private double size;
    private int colorNumbers;

    public Display(double size, int colorNumbers)
    {
        this.Size = size;
        this.ColorNumbers = colorNumbers;
    }

    public double Size
    {
        get { return this.size; }
        set 
        { 
            if (value < 0)
            {
                throw new ArgumentException("Size can't be less than zero!");
            }

           this.size = value; 
        }

    }

    public int ColorNumbers
    {
        get { return this.colorNumbers; }
        set 
        {
            if (value < 0)
            {
                throw new ArgumentException("Color numbers can't be less than zero!");
            }

            this.colorNumbers = value; 
        }
    }
   


}


