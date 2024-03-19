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
                // Request input => name of enemy
                Console.Write($"Nome do inimigo {i+1}: ");

                // store input
                string name = Console.ReadLine();

                // store info in enemy index position
                enemies[i].SetName(name); 

            }

            // just to print info
            foreach(Enemy enemy in enemies)
            {
                Console.WriteLine
                ($"{enemy.GetName()} {enemy.GetHealth()} {enemy.GetShield()}"); 
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
