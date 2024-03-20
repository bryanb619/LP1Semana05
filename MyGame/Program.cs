﻿using System;

namespace MyGame
{
    class Program
    {
        private static void Main(string[] args)
        {

            // Accept argument and convert srt to int
            int numberOfvillains = int.Parse(args[0]); 

            // array of enemies & accepts a number of enemies
            Enemy[] villains = new Enemy[numberOfvillains];


            // loop through enemies 
            for (int i = 0; i < villains.Length; i++)
            {
                // Request input => name of enemy
                Console.Write($"Nome do inimigo {i+1}: ");

                // store input
                string name = Console.ReadLine();

                // store info in enemy index position & create enemy
                villains[i] = new Enemy(name);

            }

            // just to print info
            foreach(Enemy enemy in villains)
            {
                Console.WriteLine
                ($"{enemy.GetName()} {enemy.GetHealth()} {enemy.GetShield()}"); 
            }



            ///* TESTING CODE
            // creating instance
            Enemy n = new Enemy("Loki"); 

            // displaying name
            Console.WriteLine($"{n.GetName()}");

            // change name
            n.SetName("MasterLoki");

            // get name & health
            Console.WriteLine
            ($"{n.GetName()} | HP is: {n.GetHealth()}"); 

           // */ 

        }
    }
}
