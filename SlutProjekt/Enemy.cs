public class Enemy : Fighter   // mer enemy type 1
{


    public void SpecialAttack(Fighter target)
    {
        target.TakeDamage(Damage + 5);
    }
}