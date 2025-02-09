string destination = Console.ReadLine();

while (destination != "End")
{
    int budget = int.Parse(Console.ReadLine());
    int money = 0;

    while (money < budget)
    {
        money += int.Parse(Console.ReadLine());
    }
    Console.WriteLine($"Going to {destination}!");

    destination = Console.ReadLine();
}