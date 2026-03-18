public class Enemy : Fighter
{
    public List<string> Attacks;

    public Enemy() : base()
    {
        List<string> enemyNames = new List<string> { "Oscar", "Anton", "Martin", "Mask", "Sten", "Elis" }; //Lista med namn
        Random rand = new Random();
        Name = enemyNames[rand.Next(enemyNames.Count)];  //Slumpmässigt namn från listan
        
        Attacks = new List<string> { "Slash", "Punch", "Kick", "Headbut", "throws chair" }; //lista med olika attacker
    }

    public void chooseAction(Fighter target)
    {
        Random random = new Random();
        string chosenAttack = Attacks[random.Next(Attacks.Count)];

        target.TakeDamage(Damage);

        Console.WriteLine($"{Name} använder {chosenAttack} på {target.Name} för {Damage} skada!");
        Console.WriteLine($"{target.Name} har {target.Health} hälsa kvar.");

        if (target.Health <= 0)
        {
            Console.WriteLine($"{target.Name} är besegrad!");
        }
    }
}