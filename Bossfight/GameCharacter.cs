namespace Bossfight
{
    public class GameCharacter
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int Strength { get; set; }
        public int Stamina { get; set; }

        private int maxStamina;
        private static Random rnd = new Random();

        public GameCharacter(string name, int health, int strength, int stamina)
        {
            Name = name;
            Health = health;
            Strength = strength;
            Stamina = stamina;
            maxStamina = stamina;
        }

        public void Fight(GameCharacter target, bool isBoss)
        {
            if (Stamina <= 0)
            {
                Recharge();
                Thread.Sleep(1000);
                return;
            }

            int dmg = Strength;

            if (isBoss)
            {
                dmg = rnd.Next(0, 21); // Boss skade 0-20
                Strength = dmg;
            }

            target.Health -= dmg;
            Stamina -= 10;

            Console.WriteLine(
                Name + " traff " + target.Name + " med " + dmg + " skade, " + 
                target.Name + " nå har " + target.Health + " HP igjen.");
            Thread.Sleep(1000);
        }

        public void Recharge()
        {
            Stamina = maxStamina;
            Console.WriteLine(Name + " har ikke nok stamina igjen og må slappe av denne runden.");
            Thread.Sleep(1000);
        }
    }
}