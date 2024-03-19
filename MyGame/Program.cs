using System;

namespace MyGame
{
    class Program
    {
        static void Main(string[] args)
        {
            	
            // creating instance
            Enemy enemy = new Enemy("Loki"); 

            // displaying name
            Console.WriteLine($"{enemy.GetName()}");

            enemy.SetName("MasterLoki");

            Console.WriteLine(""); 

        }
    }
}
