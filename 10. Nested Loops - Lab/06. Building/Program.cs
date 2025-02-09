int floors = int.Parse(Console.ReadLine());
int rooms = int.Parse(Console.ReadLine());

for (int floor = floors; floor >= 1; floor--)
{
    char symbol;

    if (floor == floors) symbol = 'L';
    else if (floor % 2 == 0) symbol = 'O';
    else symbol = 'A';

    for (int room = 0; room < rooms; room++)
    {
        Console.Write($"{symbol}{floor}{room} ");
    }
    Console.WriteLine();
}
