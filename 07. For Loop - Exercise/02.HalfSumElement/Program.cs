//Input
int n = int.Parse(Console.ReadLine());

//Calculations
int sum = 0;
int maxNumber = int.MinValue;

for (int i = 1; i <= n; i++)
{
    int currentNumber = int.Parse(Console.ReadLine());
    sum += currentNumber; //sum = sum + currentNumber;

    //Finding the biggest number
    if (maxNumber < currentNumber)
    {
        maxNumber = currentNumber;
    }
}

sum -= maxNumber; //sum = sum - maxNumber;

//Output
if (maxNumber == sum)
{
    Console.WriteLine("Yes");
    Console.WriteLine($"Sum = {sum}");
}
else
{
    int difference = Math.Abs(maxNumber - sum);
    Console.WriteLine("No");
    Console.WriteLine($"Diff = {difference}");
}