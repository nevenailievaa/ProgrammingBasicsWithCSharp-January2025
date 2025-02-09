//Input
int width = int.Parse(Console.ReadLine());
int length = int.Parse(Console.ReadLine());
int height = int.Parse(Console.ReadLine());

//Calculations
int freeSpace = width * length * height;
string input = "";

while ((input = Console.ReadLine()) != "Done" && freeSpace > 0)
{
    int boxesCount = int.Parse(input);
    freeSpace -= boxesCount;
}

//Output
if (freeSpace >= 0)
{
    Console.WriteLine($"{freeSpace} Cubic meters left.");
}
else
{
    Console.WriteLine($"No more free space! You need {Math.Abs(freeSpace)} Cubic meters more.");
}