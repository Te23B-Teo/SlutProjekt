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
        Health += 10;

        Console.WriteLine($"Level up! Du är nu level {Level}");
    }
    }

    public void GainXp(int amount)
    {
        Xp += amount;
        Console.WriteLine($"Du fick {amount} xp");
    }
}
