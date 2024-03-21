using System;
using System.Diagnostics;
using System.Threading;

namespace Chronos
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch crono1 = new Stopwatch();
            Stopwatch crono2 = new Stopwatch();  

            // Begin time for crono1
            crono1.Start();
            // Stop the program for 0.6 seconds
            Thread.Sleep(600);

            // Begin time for crono2
            crono2.Start();
            // Stop the program for 0.2 seconds
            Thread.Sleep(200);

            // Stop counting for both
            crono1.Stop();
            crono2.Stop();

            float time1 = crono1.Elapsed.Milliseconds/1000f;
            float time2 = crono2.Elapsed.Milliseconds/1000f;

            Console.WriteLine($"Crono 1: {time1}; Crono2: {time2}");
        }
    }
}
