//Input
double tripMoney = double.Parse(Console.ReadLine());
double savedMoney = double.Parse(Console.ReadLine());

//Calculations
int allDaysCounter = 0;
int spendDaysInRowCounter = 0;

while (savedMoney < tripMoney)
{
    string action = Console.ReadLine();
    double currentMoney = double.Parse(Console.ReadLine());

    allDaysCounter++;

    if (action == "spend")
    {
        spendDaysInRowCounter++;
        savedMoney -= currentMoney;

        if (savedMoney < 0)
        { 
            savedMoney = 0;
        }
        if (spendDaysInRowCounter == 5)
        {
            //Output
            Console.WriteLine("You can't save the money.");
            Console.WriteLine(allDaysCounter);
            break;
        }
    }
    else if (action == "save")
    {
        spendDaysInRowCounter = 0;
        savedMoney += currentMoney;
    }
}

//Output
if (savedMoney >= tripMoney)
{
    Console.WriteLine($"You saved the money for {allDaysCounter} days.");
}