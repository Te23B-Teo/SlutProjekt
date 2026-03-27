// Skapa spelare
Player player = new Player();

while (true)
{
    Console.WriteLine(@$"
Välkommen {player.Name} till fight arenan här möter du bossar och kan levla upp i rank

1: FIGHTAS!!!!!
2: kolla din information
3: lägg in quotes
4: avsluta

skriv in siffran på det du vill ska hända!
");
    string MenyVal = Console.ReadLine();


    if (MenyVal == "1")
    {
        while (true)
        {
            Fighter enemy;

            int fighterType = Random.Shared.Next(0, 2);

            if (fighterType == 0)
            {
                enemy = new Enemy();
            }
            else
            {
                enemy = new Enemy2();
            }

            Console.WriteLine($"Du möter {enemy.Name}!");
            enemy.chooseAction(player);

            Console.ReadLine();
            if (player.Health > 0 && enemy.Health <= 0)
            {
                Console.WriteLine("Du vann!");

                player.GainXp(50);
                player.LevelUp();
                break;
            }

            else if (player.Health <= 0)
            {
                Console.WriteLine("Du förlorade...");
                break;
            }

        }
    }




    else if (MenyVal == "2")
    {
        Console.WriteLine($"{player.Name}, Du har {player.Xp} Xp och är i level {player.Level}");
        for (int i = player.Quotes.Count - 1; i >= 0; i--)
{
    Console.WriteLine(player.Quotes[i]);
}
    }




    else if (MenyVal == "3")
    {
        while (true)
        {
            Console.WriteLine("skriv in vad du vill säga för quotes! skriv avsluta om du vill tillbaka till menyn");
            string QuoteVal = Console.ReadLine().ToLower();
            if (QuoteVal == "avsluta")
            {
                break;
            }
            else
            {
                player.Quotes.Add(QuoteVal);
            }
        }
    }





    else if (MenyVal == "4")
    {
        break;
    }
    else
    {
        Console.WriteLine($"{MenyVal}: Det där är inget alternativ!");
    }

}