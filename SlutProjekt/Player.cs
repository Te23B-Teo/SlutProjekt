public class Player
{
    public string PName;
    public int PDamage;
    public int PDefense;
    public int Level;
    public int Xp;
    public int PHealth;
    public List<string> Quotes;

    
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
        Level++;
    }

    public void GainXp(int amount)
    {
        Xp += amount;
    }
}
