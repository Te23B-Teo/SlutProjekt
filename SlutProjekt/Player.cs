public class Player : Fighter
{
    public string PName;
    public int PDamage;
    public int PDefense;
    public int Level;
    public int Xp;
    public int PHealth;
    public List<string> Quotes = new List<string>();

    
    public Player() : base()
    {
        Console.Write("Ange ditt namn: ");
        PName = Console.ReadLine();
        PHealth = 100;
        PDamage = Random.Shared.Next(13, 22); // Random damage 13-21
        PDefense = Random.Shared.Next(0, 9); // Random defense 0-8
        Level = 1;
        Xp = 0;
    }

    public void LevelUp()
    {
        if (Xp >= 100)
    {
        Level++;
        Xp -= 100;

        PDamage += 2;
        PHealth += 10;

        Console.WriteLine($"Level up! Du är nu level {Level}");
    }
    }

    public void GainXp(int amount)
    {
        Xp += amount;
    }
}
