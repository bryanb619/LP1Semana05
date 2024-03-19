namespace MyGame
{
    public class Enemy
    {

        // EX 6-7

        // starting variables
        private string name;
        private float health;
        private float shield; 




        // constructor
        public Enemy(string name)
        {
            this.name = name;   // Name
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


        // EX 9 

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
        public string SetName()
        {
            return name; 
        }


    }
}