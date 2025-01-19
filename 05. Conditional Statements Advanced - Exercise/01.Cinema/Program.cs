//Input
string projectionType = Console.ReadLine();
int rows = int.Parse(Console.ReadLine());
int cols = int.Parse(Console.ReadLine());

//Prices
double premierePrice = 12.00;
double normalPrice = 7.50;
double discountPrice = 5.00;

//Calculations
double income = 0;

switch (projectionType)
{
    case "Premiere":
        income = rows * cols * premierePrice;
        break;
    case "Normal":
        income = rows * cols * normalPrice;
        break;
    case "Discount":
        income = rows * cols * discountPrice;
        break;
}

//Output
Console.WriteLine($"{income:f2} leva");