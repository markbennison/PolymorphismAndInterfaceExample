namespace PolymorphismAndInterfaceExample
{
    public class Goblin : IAttackable
    {
        public int Health { get; set; } = 10;

        public void Attacked(int damage)
        {
            Health -= damage;
            Console.WriteLine($"Goblin hit for {damage} damage!  Health: {Health}");
            if (Health <= 0)
            {
                Console.WriteLine("Goblin defeated!");
            }
        }
    }

    public class Orc : IAttackable
    {
        public int Health { get; set; } = 20;

        public void Attacked(int damage)
        {
            Health -= damage;
            Console.WriteLine($"Orc hit for {damage} damage!  Health: {Health}");
            if (Health <= 0)
            {
                Console.WriteLine("Orc defeated!");
            }
        }
    }

    public class Dragon : IAttackable
    {
        public int Health { get; set; } = 50;

        public void Attacked(int damage)
        {
            Health -= damage;
            Console.WriteLine($"Dragon hit for {damage} damage!  Health: {Health}");
            if (Health <= 0)
            {
                Console.WriteLine("Dragon defeated!  The skies are safe!");
            }
        }
    }
}



