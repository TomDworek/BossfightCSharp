namespace Bossfight
{
    public static class Battle
    {
        public static void Start(GameCharacter hero, GameCharacter boss)
        {
            while (hero.Health > 0 && boss.Health > 0) // Fortsett kampen så lenge begge har helse igjen
            {
                boss.Fight(hero, true);

                if (hero.Health <= 0)
                    break;

                hero.Fight(boss, false);
            }

            if (hero.Health <= 0)
                Console.WriteLine("Boss er vinneren.");
            else
                Console.WriteLine("Hero er vinneren.");
        }
    }
}