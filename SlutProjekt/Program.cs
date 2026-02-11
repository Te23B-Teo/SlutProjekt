
Fighter f1 = new Fighter();
Fighter f2 = new Player();
Fighter f3 = new Enemy();

List<Fighter> enemies = [f1, f2, f3];

foreach(Fighter e in enemies)
{
   int EnemyDamage = e.Attack();
}

Console.ReadLine();

class Fighter
{
    public virtual int Attack()
    {
        Console.WriteLine("Attack");
        return 5;
    }
}

class Player : Fighter
{
    public override int Attack()
    {
        Console.WriteLine("Player attack");
        return 3;
    }
}

class Enemy : Fighter
{
    public override int Attack()
    {
        Console.WriteLine("Enemy attack");
        return 4;
    }
}

