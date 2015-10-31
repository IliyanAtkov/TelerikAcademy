using System;

public enum BatteryType {
    LiIon, NiMH, NiCd 
};

public class Battery
{  
    private string model;
    private int hoursIdle;
    private int hoursTalk;
    public BatteryType type { get; set; }

    public Battery()
    { 
    }

    public Battery(string model, int hoursIdle, int hoursTalk, BatteryType type)
    {
        this.Model = model;
        this.HoursIdle = hoursIdle;
        this.hoursTalk = hoursTalk;
        this.type = type;
    }

    public string Model
    {
        get { return this.model; }
        set 
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Model can't be null or empty");
            }
            this.model = value; 
        }

    }

    public int HoursIdle
    {
        get { return this.hoursIdle; }
        set 
        {
            if (value < 0)
            {
                throw new ArgumentException("Hours idle can't be less than zero!");
            }
            this.hoursIdle = value;
        }
    }
    public int HoursTalk
    {
        get { return this.hoursTalk; }
        set 
        {
            if (value < 0)
            {
                throw new ArgumentException("Hours talk can't be less than zero!");
            }
            this.hoursTalk = value; 
        }
    }
}