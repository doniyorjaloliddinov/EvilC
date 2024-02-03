using System;
using System.Net.Http;
using System.Threading.Tasks;

class Programm 
{
    static async Task Main(string[] args) 
    {
        var httpclient = new HttpClient();
        var url = "https://www.login.olx.uz";
        try 
        {
            var response = await httpclient.GetAsync(url);
            System.Console.WriteLine(response);
        }
        catch(HttpRequestException e) 
        {
            System.Console.WriteLine("\nException caught");
            System.Console.WriteLine("Message : {0}", e.Message);
        }
    }
}