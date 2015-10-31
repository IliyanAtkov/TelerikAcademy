// Write a program that downloads a file from Internet  and stores it the current
// directory. Find in Google how to download files
// in C#. Be sure to catch all exceptions and to free any used resources
// in the finally block.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;


class DownloadFileFromTheInternet
{
    static void DownloadFile()
    {
        using (WebClient Client = new WebClient())
        {
            try
            {
                Client.DownloadFile("http://www.ausairpower.net/PLA/DF-21-TEL-2S.jpg", "missle.jpg");
                Console.WriteLine("Done the picture is in Debug Folder");
            }

            catch (SystemException s)
            {
                Console.Error.WriteLine("The address is invalid. " + s.GetType().Name + " " + s.Message);//this will initialise all possible exeptions and will show the current exeption, if any occur
            }
        }

    }
    static void Main()
    {
        DownloadFile();
    }
}

