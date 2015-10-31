using System;
using System.Collections.Generic;
using System.Text;

public class Call
{
    private DateTime dateAndTimeNow;
    private int duration;
    private string dialedPhoneNumber;

    public Call(DateTime dateAndTimeNow, int duration, string dialedPhoneNumber)
    {
        this.dateAndTimeNow = dateAndTimeNow;
        this.duration = duration;
        this.dialedPhoneNumber = dialedPhoneNumber;
    }

    public DateTime DateAndHour
    {
        get { return this.dateAndTimeNow; } 
        set { this.dateAndTimeNow = value; }
    }

    public int Duration
    {
        get { return this.duration; }
        set { duration = value; }
    }

    public string DialedPhoneNumber
    {
        get { return this.dialedPhoneNumber; }
        set { dialedPhoneNumber = value; }
    }
    
}