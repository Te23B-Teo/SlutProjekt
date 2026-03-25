public class Enemy : Fighter
{


    public void chooseAction(Fighter target)
    {
        string chosenAttack = Attacks[Random.Shared.Next(Attacks.Count)];

        target.TakeDamage(Damage);

        Console.WriteLine($"{Name} använder {chosenAttack} på {target.Name} för {Damage} skada!");
        Console.WriteLine($"{target.Name} har {target.Health} hälsa kvar.");

        if (target.Health <= 0)
        {
            Console.WriteLine($"{target.Name} är besegrad!");
        }
    }
}