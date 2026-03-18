public class Player : Fighter
{
    public int Level;
    public int Xp;

    
    public Player() : base()
    {
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
