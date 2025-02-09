int n = int.Parse(Console.ReadLine());
int count = 0;

for (int x1 = 0; x1 <= n; x1++)
{
    for (int x2 = 0; x2 <= n; x2++)
    {
        for (int x3 = 0; x3 <= n; x3++)
        {
            int result = x1 + x2 + x3;
            Console.WriteLine($"{x1} + {x2} + {x3} = {result}");
            if (result == n)
                count++;
        }
    }
}

Console.WriteLine(count);