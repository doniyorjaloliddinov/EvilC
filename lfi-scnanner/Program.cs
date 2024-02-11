using System;
using System.Net;

namespace LFIScanner 

{
    class Programm 
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("[+]Enter target url>> ");
            string url = Console.ReadLine();

            System.Console.WriteLine("[+]Enter a payload>> ");
            string payload = Console.ReadLine();

        try
        {
            string response = FetchContent(url + payload);
            if(response.Contains("root:"))
            {
                System.Console.WriteLine($"LFI vulnerability found at {url + payload}");
            } 
            else 
            {
                System.Console.WriteLine($"No LFI vulnerability found at {url + payload}");
            }
        }
        catch(WebException ex)
        {
            System.Console.WriteLine(ex.Message);
        }

        static string FetchContent(string uri)
        {
            using(WebClient client = new WebClient())
            {
                return client.DownloadString(uri);
            }
        }
        }

        
    }
}