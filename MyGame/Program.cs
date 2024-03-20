using System;

namespace MyGame
{
    class Program
    {
        private static void Main(string[] args)
        {

            // Accept argument and convert srt to int
            int numberOfVillains = int.Parse(args[0]); 

            // array of enemies & accepts a number of enemies
            Enemy[] villains = new Enemy[numberOfVillains];


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


            // EX 12

            // take damage
            villains[0].TakeDamage(60);

            // Power Up Health
            villains[0].PickupPowerUp(PowerUp.Health, 10);

            // Power Up shield
            villains[0].PickupPowerUp(PowerUp.Shield, 15);

            // Power Up Health
            villains[0].PickupPowerUp(PowerUp.Health, 10);


            // test with more
            if(villains.Length > 1)
            {
                // take damage
                villains[1].TakeDamage(60);

                // Power Up shield
                villains[1].PickupPowerUp(PowerUp.Shield, 15);

            }

            
            // print info
            for(int i = 0; i < villains.Length; i++)
            {
                // print info with power ups
                Console.WriteLine
                ($"{villains[i].GetName()} {villains[i].GetHealth()}"
                + $" {villains[i].GetShield()} {Enemy.GetPowerUpsCollected()}"); 
            }

        
           




            /* TESTING CODE 
            // creating instance
            Enemy n = new Enemy("Loki"); 

            // displaying name
            Console.WriteLine($"{n.GetName()}");

            // change name
            n.SetName("MasterLoki");

            // get name & health
            Console.WriteLine
            ($"{n.GetName()} | HP is: {n.GetHealth()}"); 

           */ 

        }
    }
}
