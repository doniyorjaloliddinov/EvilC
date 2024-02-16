using System;
using System.Net;
using System.Net.Sockets;

class Program
{
    static void Main(string[] args)
    {
        string domain = "asaxiy.uz"; // Specify the domain to scan
        ScanSubdomains(domain);
    }

    static void ScanSubdomains(string domain)
    {
        string[] subdomains = {
            "www",
            "mail",
            "blog",
            "ftp",
            "api",
            "dev",
            "test",
            "admin",
            "stage",
            "demo",
            "m",
            "mobile",
            "webmail",
            "app",
            "apps",
            "shop",
            "store",
            "payment",
            "billing",
            "secure",
            "login",
            "signin",
            "oauth",
            "register",
            "en",
            "es",
            "fr",
            "de",
            "cn",
            "jp",
            "crm"
        };

        foreach (string subdomain in subdomains)
        {
            string fullSubdomain = $"{subdomain}.{domain}";
            try
            {
                IPHostEntry ipHostEntry = Dns.GetHostEntry(fullSubdomain);
                Console.WriteLine($"Subdomain found: {fullSubdomain} ({ipHostEntry.AddressList[0]})");
            }
            catch (SocketException)
            {
                Console.WriteLine($"Subdomain not found: {fullSubdomain}");
            }
        }
    }
}
