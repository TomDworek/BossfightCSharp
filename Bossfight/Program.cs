using Bossfight;

namespace Bossfight
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GameCharacter hero = new GameCharacter("Hero", 100, 20, 40); // Hero med 100 HP, 20 strength, 40 stamina
            GameCharacter boss = new GameCharacter("Boss", 400, 0, 10); // Boss med 400 HP, strength er random 0-20, 10 stamina
            Battle.Start(hero, boss);
        }
    }
}