using System;

public class GSMCallHistoryTest
{
    GSM phone = new GSM("3310", "Nokia", 5, "Gosho");
    public GSM AddTestCalls(GSM phone)
    {
      phone.AddCall(DateTime.Now, 3, "087612312");
      phone.AddCall(DateTime.Now, 2, "089810345");
      phone.AddCall(DateTime.Now, 5, "088832323");
      return phone;
    }

    public void RemoveBiggestCall(GSM phone)
    {
        int longestTalk = 0;
        int index = 0; 
        for (int i = 0; i < phone.CallHistory.Count; i++)
        {
            if (phone.CallHistory[i].Duration > longestTalk)
            {
                longestTalk = phone.CallHistory[i].Duration;
                index = i;
            }
        }
        phone.CallHistory.RemoveAt(index);
    }    
}