public class Fighter
{
    public string Name;
    public int Damage;
    public int Health;
    public int Defense;
    public List<string> Quotes;

    public Fighter()
    {
        Quotes = new List<string>();
        Health = 100;
    }
}