//Input
int age = int.Parse(Console.ReadLine());
double washingMachinePrice = double.Parse(Console.ReadLine());
int toyPrice = int.Parse(Console.ReadLine());

//Calculations
int toysCount = 0;
int money = 0;
int moneyIntake = 0;

for (int currentAge = 1; currentAge <= age; currentAge++)
{
    if (currentAge % 2 == 1)
    {
        toysCount++;
    }
    else
    {
        moneyIntake += 10;
        money += moneyIntake;

        //Brother takes 1 lv.
        money--;
    }
}

money += toysCount * toyPrice;

//Output
if (money >= washingMachinePrice)
{
    double remainingMoney = money - washingMachinePrice;
    Console.WriteLine($"Yes! {remainingMoney:f2}");
}
else
{
    double remainingMoney = washingMachinePrice - money;
    Console.WriteLine($"No! {remainingMoney:f2}");
}