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


           


            // start crono 1
            crono1.Start();

            // sleep 0.6 seconds
            Thread.Sleep(600);

            // start crono 2
            crono2.Start(); 

            // sleep 0.2 seconds
            Thread.Sleep(200);

            // === STOP ALL ===
            crono1.Stop();
            crono2.Stop(); 


            string elapsed1 = String.Format(" ", crono1); 


           


        }
    }
}
