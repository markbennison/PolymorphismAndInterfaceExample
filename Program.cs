namespace PolymorphismAndInterfaceExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PlayGame();

            Console.ReadLine();
        }

        static void PlayGame()
        {
            IAttackable[] enemies = new IAttackable[]
            {
            new Goblin(),
            new Orc(),
            new Dragon()
            };

            foreach (IAttackable enemy in enemies)
            {
                enemy.Attacked(5); //  Attack each enemy with 5 damage
            }
        }
    }
}


