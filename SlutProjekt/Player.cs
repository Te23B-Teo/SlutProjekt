public class Player : Fighter
{
    public int Level;
    public int Xp;
    public List<string> Quotes = new List<string>();


    public Player() : base()
    {
        Console.Write("Ange ditt namn: ");
        Name = Console.ReadLine();

        Level = 1;
        Xp = 0;
    }

    public void LevelUp()
    {
        if (Xp >= 100)
        {
            Level++;
            Xp -= 100;

            Damage += 2;
            Health += 5;

            Console.WriteLine($"Level up! Du är nu level {Level}");
            Thread.Sleep(1000);
        }
    }

    public void QuotePower()
    {
        if (Quotes.Count == 0)
        {
            Console.WriteLine();
            Console.WriteLine("Du har inga quotes!");
            return;
        }
        int antal = Random.Shared.Next(Quotes.Count);
        Console.WriteLine();
        Console.WriteLine($"{Name} Säger: {Quotes[antal]}");
        Health += 5;
        Console.WriteLine();
        Console.WriteLine("(+5 hp för Quote)");
    }

    public void GainXp(int amount)
    {
        Xp += amount;
        Console.WriteLine($"Du fick {amount} xp");
    }
}
