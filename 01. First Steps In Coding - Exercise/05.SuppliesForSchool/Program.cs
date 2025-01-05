//Prices
double penPacketPrice = 5.80;
double markersPacketPrice = 7.20;
double cleanerLiterPrice = 1.20;

//Input
int penPacketsCount = int.Parse(Console.ReadLine());
int markerPacketsCount = int.Parse(Console.ReadLine());
int cleanerLitersCount = int.Parse(Console.ReadLine());
int percentDiscount = int.Parse(Console.ReadLine());

//Calculations
double bill = (penPacketPrice * penPacketsCount) + (markersPacketPrice * markerPacketsCount) + (cleanerLiterPrice * cleanerLitersCount);

double billWithDiscount = bill - (bill * percentDiscount / 100);

//Output
Console.WriteLine(billWithDiscount);