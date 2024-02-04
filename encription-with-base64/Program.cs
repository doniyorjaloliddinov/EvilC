using System;
using System.IO;

namespace Encription 

{
    class Programm 
    
    {
        static void Main(string[] args) 
        {
            string fPath = @"D:\gwagen.png";
            byte[] bytes = File.ReadAllBytes(fPath);
            string file = Convert.ToBase64String(bytes);
            System.Console.WriteLine(file);
            // System.Console.WriteLine("converting Base64 to string ...\n" + file);
            System.Console.WriteLine("Press any key to exit");
            Console.ReadLine();
        }
    }
}