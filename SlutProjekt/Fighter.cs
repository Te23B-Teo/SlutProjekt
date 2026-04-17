public class Fighter
{

    public string Name;
    public int Damage;
    public int Health;
    public int Defense;
    public List<string> Attacks;


    public Fighter()
    {
        Health = 100;
        Defense = Random.Shared.Next(0, 9); // Random defense 0-8


        List<string> enemyNames = new List<string> { "Oscar", "Anton", "Martin", "Mask", "Sten", "Elis", "Jackson" }; //Lista med namn
        Attacks = new List<string> { "Slash", "Punch", "Kick", "Headbut", "throws chair", "over head swing", "stomp attack", "leg sweep", "drop kick" }; //lista med olika attacker


        Name = enemyNames[Random.Shared.Next(enemyNames.Count)];  //Slumpmässigt namn från listan

    }

    public void TakeDamage(int amount)
    {

        int actualDamage = amount - Defense;

        if (actualDamage > 0)
        {
            Health -= Damage;
        }
    }

    public void chooseAction(Fighter target)
    {
        Damage = Random.Shared.Next(13, 22); // Random damage 13-21

        string chosenAttack = Attacks[Random.Shared.Next(Attacks.Count)];

        target.TakeDamage(Damage);
        Console.WriteLine($"{Name} använder {chosenAttack} på {target.Name} för {Damage} skada!");
        Console.WriteLine($"{target.Name} har {target.Health} hälsa kvar.");
    }
    public int MaxHealth = 100;

    public void ResetStats()
    {
        Health = MaxHealth;
    }
}