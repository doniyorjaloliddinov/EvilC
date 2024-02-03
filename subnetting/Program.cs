using System;
using System.Net.Http;
using System.Threading.Tasks;

class Programm 
{
    static async Task Main(string[] args) 
    {
        var httpclient = new HttpClient();
        var url = "https://www.google.com";
        var response = await httpclient.GetAsync(url);
        System.Console.WriteLine(response);
    }
}