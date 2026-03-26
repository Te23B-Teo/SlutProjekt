// Skapa spelare och fiende
Player player = new Player();
Enemy enemy = new Enemy();

while (true)
{
    Console.WriteLine(@$"
Välkommen {player.PName} till fight arenan här möter du bossar och kan levla upp i rank

1: FIGHTAS!!!!!
2: kolla din information
3: lägg in quotes
4: avsluta

skriv in siffran på det du vill ska hända!
");
    string MenyVal = Console.ReadLine();

    if (MenyVal == "1")
    {
       int fighter = Random.Shared.Next(0,1); 
       if(fighter == 0)
        {
            {enemy.Name}
        }
        else
        {
            {enemy2.Name}
        }
    }
    else if (MenyVal == "2")
    {
        Console.WriteLine($"{player.PName}");
    }
    else if (MenyVal == "2")
    {

    }
    else if (MenyVal == "4")
    {
        break;
    }

}