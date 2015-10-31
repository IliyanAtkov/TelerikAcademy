using System;
using System.Collections.Generic;

public class GSM
{
    
    private static GSM iPhone4S;
    private string model; 
    private string manafacturer;
    private int price;
    private string owner;
    private List<Call> callHistory = new List<Call>();
    private Display display;
    private Battery battery;

    // constructors
    public GSM(string model, string manufacturer, int price, string owner, Battery battery, Display display)
    {
        this.Model = model;
        this.Manafacturer = manufacturer;
        this.Price = price;  
        this.owner = owner;
        this.battery = battery;
        this.display = display;
    }

    public GSM(string model, string manafacturer)
        : this(model, manafacturer, 0, null, null, null)
    {
    }

    public GSM(string model, string manafacturer, int price)
        : this(model, manafacturer, price, null, null, null)
    {
    }

    public GSM(string model, string manafacturer, int price, string owner)
        : this(model, manafacturer, price, owner, null, null)
    {
    }

    public GSM(string model, string manafacturer, int price, string owner, Battery battery)
        : this(model, manafacturer, price, owner, new Battery(), null)
    {
    }

    static GSM()
    {
        iPhone4S = new GSM("Iphone 4S", "Apple", 1300, "Gosho");
    }

    // properties
    public List<Call> CallHistory
    {
        get { return this.callHistory; }
        set { this.callHistory = value; }
    }

    public static GSM IPhone4S
    {
        get { return iPhone4S; }
    }
    
    public string Model
    {
        get { return this.model; }
        set 
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Model can't be null or empty!");
            }
            this.model = value;
        }
	}

    public string Manafacturer
    {
        get { return this.manafacturer; }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Manafacturer can't be null or empty!");
            }
            this.manafacturer = value;
        }  
    }

    public int Price
    {
        get { return this.price; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("The price can't be less than zero!");              
            }
            this.price = value;
        }
    }

    public string Owner
    {
        get { return this.owner; }
        set{ this.owner = value; }
    }

    
    // methods

    public void AddCall(DateTime dateAndTimeNow, int duration, string dialedPhoneNumber)
    {
        Call newCall = new Call(dateAndTimeNow, duration, dialedPhoneNumber);
        callHistory.Add(newCall);
    }
    public void RemoveCall(int duration)
    {
        for (int i = 0; i < callHistory.Count; i++)
        {
            if (callHistory[i].Duration == duration)
            {
                callHistory.RemoveAt(i);
                i--;
            }
        }
    }
    public void ClearCalls()
    {
        callHistory.Clear();
    }
    public decimal CalculatePrice(decimal pricePerMinute)
    {
        int totalTime = 0;
        decimal totalPrice = 0m;
        for (int i = 0; i < callHistory.Count; i++)
        {
            totalTime += callHistory[i].Duration;
        }
        totalPrice = totalTime * pricePerMinute;
        return totalPrice;        
    }
    public void PrintCalls()
    {
        for (int i = 0; i < CallHistory.Count; i++)
        {
            Console.WriteLine("Calls ");
            Console.WriteLine("Date and Time: " + CallHistory[i].DateAndHour);
            Console.WriteLine("Dialed number: " + CallHistory[i].DialedPhoneNumber);
            Console.WriteLine("Duration: {0} minutes ", CallHistory[i].Duration);
            Console.WriteLine();
        }
    }


    public override string ToString()
    {
        string evaluatedPrice;

        if (this.Price == 0)
        {
            evaluatedPrice = "No Price Set";
        }
        else
        {
            evaluatedPrice = Convert.ToString(string.Format("{0} euro", this.Price));
        }

        return string.Format("Model: {0}\nManufacturer: {1}\nPrice: {2}\nOwner: {3}\n{4}\n{5}",
            this.Model, this.Manafacturer, evaluatedPrice, this.Owner, this.battery, this.display);
    }

} 
