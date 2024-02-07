using System;
using System.Net;

class Program 
{
    static HttpClient client = new HttpClient();

    static HttpResponseMessage Request(string url)
    {
        try 
        {
            return client.GetAsync(url).Result;
        }
        catch(HttpRequestException)
        {
            System.Console.WriteLine("Error request is guven!");
            return null;
        }
    }

    static void Main(string[] args)
    {
        System.Console.WriteLine("[+]Enter target url>> ");
        string target_url = Console.ReadLine();
        HttpResponseMessage response = Request(target_url);
        if (response !=null)
        {
            System.Console.WriteLine(response.Content.ReadAsStringAsync().Result);
        }
    }

}