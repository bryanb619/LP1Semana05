namespace MyGame
{
    public class Enemy
    {
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
    }
}