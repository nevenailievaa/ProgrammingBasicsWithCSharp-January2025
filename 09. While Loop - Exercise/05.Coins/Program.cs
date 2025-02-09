//Input
double inputChange = double.Parse(Console.ReadLine());

//Calculations
int change = (int)Math.Round(inputChange * 100); //We pass in pennies and round up because of errors with the double type
int coinsCounter = 0;

while (change > 0)
{
    if (change - 200 >= 0)
    {
        change -= 200;
        coinsCounter++;
        continue;
    }
    else if (change - 100 >= 0)
    {
        change -= 100;
        coinsCounter++;
        continue;
    }
    else if (change - 50 >= 0)
    {
        change -= 50;
        coinsCounter++;
        continue;
    }
    else if (change - 20 >= 0)
    {
        change -= 20;
        coinsCounter++;
        continue;
    }
    else if (change - 10 >= 0)
    {
        change -= 10;
        coinsCounter++;
        continue;
    }
    else if (change - 5 >= 0)
    {
        change -= 5;
        coinsCounter++;
    }
    else if (change - 2 >= 0)
    {
        change -= 2;
        coinsCounter++;
        continue;
    }
    else if (change - 1 >= 0)
    {
        change -= 1;
        coinsCounter++;
        continue;
    }
}

//Output
Console.WriteLine(coinsCounter);