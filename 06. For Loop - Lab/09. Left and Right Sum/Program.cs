int n = int.Parse(Console.ReadLine()); //3

int leftSum = 0;
for(int i = 1; i <= n; i++)
{
    leftSum += int.Parse(Console.ReadLine());
}

int rightSum = 0;
for (int i = 1;i <= n; i++)
{
    rightSum += int.Parse(Console.ReadLine());
}

if (leftSum == rightSum)
    Console.WriteLine($"Yes, sum = {leftSum}");
else
    Console.WriteLine($"No, diff = {Math.Abs(leftSum-rightSum)}");