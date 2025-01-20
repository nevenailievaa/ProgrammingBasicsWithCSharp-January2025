int number = int.Parse(Console.ReadLine());

bool isValid = (number > 10) && (number % 2 == 0);

if (!isValid)
{
    Console.WriteLine("Invalid");
}
