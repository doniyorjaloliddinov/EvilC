using System;
using System.Net.Http;
using HtmlAgilityPack;


namespace HtmlForms
{
    class Program 
    {
        static void Main(string[] args)
        {
            string targetUrl = "";
            HttpClient httpClient = new HttpClient();
            string content = httpClient.GetStringAsync(targetUrl).Result;

            HtmlDocument htmlDocument = new HtmlDocument();
            htmlDocument.LoadHtml(content);

            var formList = htmlDocument.DocumentNode.SelectNodes("//forms");

            foreach(var form in formList)
            {
                var action = form.GetAttributeValue("action", "");
                System.Console.WriteLine(action);

                var method = form.GetAttributeValue("method");
                System.Console.WriteLine(method);

                var inputList = form.SelectNodes("//input");

                foreach(var input in inputList)
                {
                    var inputName = input.GetAttributeValue("name", "");
                    System.Console.WriteLine(inputName);
                }
            }
        }
    }
}
