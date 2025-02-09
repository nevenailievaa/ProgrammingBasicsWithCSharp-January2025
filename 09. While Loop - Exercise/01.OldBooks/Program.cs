//Input
string searchedBook = Console.ReadLine();

//Calculations
int bookCounter = 0;
string input = "";

while ((input = Console.ReadLine()) != "No More Books" && input != searchedBook)
{
    bookCounter++;
}

//Output
if (input == searchedBook)
{
    Console.WriteLine($"You checked {bookCounter} books and found it.");
}
else
{
    Console.WriteLine("The book you search is not here!");
    Console.WriteLine($"You checked {bookCounter} books.");
}