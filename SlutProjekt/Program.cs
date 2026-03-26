// Skapa spelare och fiende
Player player = new Player();
Enemy enemy = new Enemy();


Console.WriteLine(@$"
Välkommen {player.PName} till fight arenan här möter du bossar och kan levla upp i rank

1: FIGHTAS mot {enemy.Name}
2: kolla din information
3: lägg in quotes

skriv in siffran på det du vill ska hända!
");
string MenyVal = Console.ReadLine();

if (MenyVal == "1")
{
    
}
Console.ReadLine();