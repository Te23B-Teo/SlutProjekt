public class Enemy : Fighter   // mer enemy type 1
{


    public override void chooseAction(Fighter target)
    {
        Console.WriteLine($" {Name}");
    target.TakeDamage(Damage + 5);
    }
}