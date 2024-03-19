using System;
using System.Diagnostics;

// must use thread
using System.Threading; 

namespace Chronos
{
    class Program
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args">Not Used</param>
        private static void Main(string[] args)
        {

            // instances of a class

            // instance crono1 
            Stopwatch crono1 = new Stopwatch(); 

            // instance crono2
            Stopwatch crono2 = new Stopwatch();




            // start crono1
            crono1.Start();

            // sleep 0.6 seconds
            Thread.Sleep(600); 

        



           // Console.WriteLine("Hello, World!");


        }
    }
}
