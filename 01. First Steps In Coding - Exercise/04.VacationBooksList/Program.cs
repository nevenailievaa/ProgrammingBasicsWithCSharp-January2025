//Input
int bookPages = int.Parse(Console.ReadLine());
int pagesPerHour = int.Parse(Console.ReadLine());
int daysToRead = int.Parse(Console.ReadLine());

//Calculations
int readingHoursPerDay = bookPages / pagesPerHour / daysToRead;

//Output
Console.WriteLine(readingHoursPerDay);