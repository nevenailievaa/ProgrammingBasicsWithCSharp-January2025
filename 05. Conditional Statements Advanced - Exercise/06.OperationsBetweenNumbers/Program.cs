//Input
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
char operation = char.Parse(Console.ReadLine());

//Calculations
double result = 0;

if (operation == '+')
{
    result = a + b;

    if (result % 2 == 0)
    {
        Console.WriteLine($"{a} + {b} = {result} - even");
    }
    else
    {
        Console.WriteLine($"{a} + {b} = {result} - odd");
    }
}
else if (operation == '-')
{
    result = a - b;

    if (result % 2 == 0)
    {
        Console.WriteLine($"{a} - {b} = {result} - even");
    }
    else
    {
        Console.WriteLine($"{a} - {b} = {result} - odd");
    }
}
else if (operation == '*')
{
    result = a * b;

    if (result % 2 == 0)
    {
        Console.WriteLine($"{a} * {b} = {result} - even");
    }
    else
    {
        Console.WriteLine($"{a} * {b} = {result} - odd");
    }
}
else if (operation == '/')
{
    if (b == 0)
    {
        Console.WriteLine($"Cannot divide {a} by zero");
    }
    else
    {
        result = a / (double)b;
        Console.WriteLine($"{a} / {b} = {result:f2}");
    }
}
else if (operation == '%')
{
    if (b == 0)
    {
        Console.WriteLine($"Cannot divide {a} by zero");
    }
    else
    {
        result = a % b;
        Console.WriteLine($"{a} % {b} = {result}");
    }
}