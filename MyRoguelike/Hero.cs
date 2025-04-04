namespace MyRoguelike
{
    public class Hero
    {
        private int xp;
        private float health;
        private readonly string name;
        public string Name => name;
        
        public int XP
        {
            get => xp;
            set
            {
                if (value > xp)
                {
                    xp = value;
                }
            }
        }

        public int Level => (int)(XP / 1000) + 1;

        private float MaxHealth => 100 + (Level - 1) * 20;
        public float Health
        {
            get => health;
            set
            {
                if (value < 0)
                {
                    health = 0;
                }
                else if (value > MaxHealth)
                {
                    health = MaxHealth;
                }
                else
                {
                    health = value;
                }
            }
        }
    }
}