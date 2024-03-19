using System;

namespace MyGame
{
    class Program
    {
        private static void Main(string[] args)
        {

 
            // Accept argument and convert srt to int
            int numberOfEnemies = int.Parse(args[0]); 

            // array of enemies & accepts a number of enemies
            Enemy[] enemies = new Enemy[numberOfEnemies];


            // loop through enemies 
            for (int i = 0; i < enemies.Length; i++)
            {

            }



            /* TESTING CODE
            // creating instance
            Enemy enemy = new Enemy("Loki"); 

            // displaying name
            Console.WriteLine($"{enemy.GetName()}");

            // change name
            enemy.SetName("MasterLoki");

            // get name & health
            Console.WriteLine
            ($"{enemy.GetName()} | HP is: {enemy.GetHealth()}"); 

            */ 



        }
    }
}
