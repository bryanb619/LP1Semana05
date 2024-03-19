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

            // random class & provide seed
            Random random = new Random(s);

            // final result of dice 
            int diceResult = 0; 

            // loop until n times
            for(int i = 0; i < n; i++)
            {
                // Get random dice value 
                // store in a int
                int randomNumber = random.Next(1, 6);

                // === DEBUG ===
                //Console.WriteLine(randomNumber); 
                // dotnet run --project RanDice -- 3 334

                // Add values
                diceResult += randomNumber;

                // Reset randomNumber value
                randomNumber = 0;  
            }

            // Print final result
            Console.WriteLine(diceResult); 
        }
    }
}
