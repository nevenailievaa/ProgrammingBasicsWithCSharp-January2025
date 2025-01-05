//Input
int yearBasketballFee = int.Parse(Console.ReadLine());

//Calculations
double shoesPrice = yearBasketballFee - (yearBasketballFee * 0.4);
double equipmentPrice = shoesPrice - (shoesPrice * 0.2);
double basketballPrice = equipmentPrice / 4;
double accessoriesPrice = basketballPrice / 5;

double bill = yearBasketballFee + shoesPrice + equipmentPrice + basketballPrice + accessoriesPrice;

//Output
Console.WriteLine(bill);