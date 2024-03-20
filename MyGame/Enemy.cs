using System;

namespace MyGame
{
    public class Enemy
    {

        // EX 6-7

        // starting variables
        private string name;
        private float health;
        private float shield; 


        // EX - 12 

        // Static variables
        private static int powerUpsColl;
        

        // constructor
        public Enemy(string name)
        {
            //this.name = name;   // Name
            SetName(name);         
            health = 100;       // Health
            shield = 0;         // shield

        }

        // EX 8

        // Get character name
        public string GetName()
        {
            return name; 
        }

        // take damage
        public void TakeDamage(float damage)
        {
            // apply damage on shield
            shield -= damage; 

            // if no shield
            if(shield < 0)
            {
                float damageStilToInflict = -shield;


                shield = 0;

                // remove on health
                health -= damageStilToInflict; 

                if(health < 0)
                {
                    health = 0; 
                }

            }

        }


        // EX 9 - 10

        // Get Health
        public float GetHealth()
        {
            return health; 
        }

        // Get Shield
        public float GetShield()
        {
            return shield; 
        }

        // Set name
        public string SetName(string newName)
        {

            if(newName.Length > 8)
            {

                string temp=""; 

                int i = 0; 

                foreach(char c in newName)
                {
                    if(i < 8)
                    {
                        temp += c; 
                        i++; 

                    }
                }

                name = temp; 

            }
            else
            {
                // set instance name to new name
                name = newName; 

            }

            return name; 
        }


        // EX 11

        /// <summary>
        ///  Accepts 2 param.
        ///  1st param: a power up such as health or shield 
        ///  2nd param: the value of this power up
        ///  Uses both info and applies value to the power up
        /// /// </summary>
        /// <param name="powerUp">Power up value</param>
        /// <param name="value">Value of power up(0-100)</param>
        public void PickupPowerUp(PowerUp powerUp, float value)
        {

            // Add logic to value

            // detect if value

            // if value is higher than 100
            if(value > 100)
            {
                // reset value
                value = 100; 
            }


            switch(powerUp)
            {
                case PowerUp.Health:
                {
                    // Check if health + value > 100f
                    if(health + value > 100f)
                    {
                        // reset health
                        health = 100f; 

                    }
                    else
                    {   // add to health
                        health += value; 
                    }

                    break; 
                }

                case PowerUp.Shield:
                {
                    // Check if shield + value > 100f
                    if(shield + value > 100f)
                    {
                        // reset shield
                        shield = 100f; 

                    }
                    else
                    {   // add to shield
                        shield += value; 
                    }

                    break;
                }
            }


        }

        public static GetPowerUpsCollected()
        {
            return powerUpsColl; 
        }

    }
}