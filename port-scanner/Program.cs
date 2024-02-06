
using System;
using System.Net;
using System.Net.Sockets;

namespace PortScanner
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("[+]Enter IP address>> ");
            string ipAddress = Console.ReadLine();
            Console.WriteLine("[+]Enter start port number>> ");
            int startPort = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("[+]Enter end port number>> ");
            int endPort = Convert.ToInt32(Console.ReadLine());
            
            IPAddress ip;
            if (IPAddress.TryParse(ipAddress, out ip))
            {
                Console.WriteLine($"[+]Scanning for ports on {ipAddress}");
                Console.WriteLine("Port\t\tStatus");
                
                for (int port = startPort; port <= endPort; port++)
                {
                    using (TcpClient client = new TcpClient())
                    {
                        try
                        {
                            client.Connect(ip, port);
                            Console.WriteLine($"[+]{port}\t\tOpen");
                        }
                        catch (SocketException)
                        {
                            Console.WriteLine($"[-]{port}\t\tClosed");
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("Invalid IP address.");
            }
        }
    }
}