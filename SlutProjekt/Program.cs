// Skapa spelare
Player player = new Player();

while (true)
{
    Console.Clear();
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


        while (true)
        {
            Console.Clear();
            Console.Write("loading");
            for(int i = 0; i<5;i++)
            {
            Console.Write(".");
            Thread.Sleep(100);
            }
            Console.Clear();
            Console.WriteLine("Vill du slåss eller fly skriva (ja) om du vill fly annars tryck på enter");
            string fly = Console.ReadLine();
            if(fly?.ToLower() == "ja")
            {
                break;
            }
            else
            {
            Console.WriteLine($"{player.Name}: defence {player.Defense}");
            Console.WriteLine($"{enemy.Name}: defence {enemy.Defense}");
            Console.WriteLine("");
            enemy.chooseAction(player);
            player.chooseAction(enemy);
            player.GainXp(5);
            int random = Random.Shared.Next(0,2);
            if(random == 1)
                {
                player.QuotePower();
                }
            }
            
                

            Console.ReadLine();
            if (enemy.Health <= 0)
            {
                Console.Clear();
                Console.WriteLine("Du vann!");
                player.GainXp(50);
                player.LevelUp();
                player.ResetStats();
                enemy.ResetStats();
                Console.ReadLine();
                break;
            }

            else if(player.Health <= 0)
            {
                Console.Clear();
                Console.WriteLine("Du förlorade...");
                Console.ReadLine();
                break;
            }

        }
    }




    else if (MenyVal == "2")
    {
        Console.Clear();
        Console.WriteLine($"{player.Name}, Du har {player.Xp} Xp och är i level {player.Level}");
        Console.WriteLine("");
        Console.WriteLine("Dessa är dina quotes!");
        Console.WriteLine("");
        for (int i = player.Quotes.Count - 1; i >= 0; i--)
{
    Console.WriteLine(player.Quotes[i]);
}
    Console.ReadLine();
    }




    else if (MenyVal == "3")
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("skriv in vad du vill säga för quotes! skriv avsluta om du vill tillbaka till menyn");
            string QuoteVal = Console.ReadLine();
            if (QuoteVal.ToLower() == "avsluta")
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
        Console.Clear();
        Console.WriteLine($"({MenyVal}) är inget alternativ!");
        Thread.Sleep(1500);
    }

}