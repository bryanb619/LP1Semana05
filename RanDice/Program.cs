using System;

namespace RanDice
{
    class Program
    {
        private static void Main(string[] args)
        {

            // read arg 0 & convert to int
            int n = int.Parse(args[0]);

            // read arg 1 & convert to int
            int s = int.Parse(args[1]);

            Random r1 = new Random(s);
            int diceResult = 0; 

  

            // loop until n times
            for(int i = 0; i < n; i++)
            {
                // add random range for n number passed by user args[0]
                int randomNumber = r1.Next(1, 6);

                // === DEBUG ===
                //Console.WriteLine(randomNumber); 
                // dotnet run --project RanDice -- 3 334
                diceResult += randomNumber;

                // Reset randomNumber value
                randomNumber = 0;  
            }

            Console.WriteLine(diceResult); 



        }
    }
}
