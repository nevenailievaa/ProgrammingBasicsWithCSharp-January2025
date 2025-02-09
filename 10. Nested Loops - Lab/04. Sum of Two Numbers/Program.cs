int start = int.Parse(Console.ReadLine());
int end = int.Parse(Console.ReadLine());

int magicNum = int.Parse(Console.ReadLine());

int count = 0;
bool isFound = false;

for (int x = start; x <= end; x++)
{
    for (int y = start; y <= end; y++)
    {
        int result = x + y;
        count++;

        if (result == magicNum)
        {
            isFound = true;
            Console.WriteLine($"Combination N:{count} ({x} + {y} = {magicNum})");
            break;
        }
    }
    if (isFound)
        break;
}

if (!isFound)
    Console.WriteLine($"{count} combinations - neither equals {magicNum}");
