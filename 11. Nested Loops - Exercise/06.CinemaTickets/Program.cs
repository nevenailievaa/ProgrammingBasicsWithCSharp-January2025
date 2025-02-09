//Input
string movieName = "";

//Calculations
int studentTickets = 0;
int standardTickets = 0;
int kidTickets = 0;
int totalTickets = 0;

while ((movieName = Console.ReadLine()) != "Finish")
{
    int seatsCount = int.Parse(Console.ReadLine());
    string ticketType = "";
    int soldTickets = 0;

    while ((ticketType = Console.ReadLine()) != "End")
    {
        soldTickets++;

        switch (ticketType)
        {
            case "student":
                studentTickets++;
                break;
            case "standard":
                standardTickets++;
                break;
            case "kid":
                kidTickets++;
                break;
        }

        if (soldTickets == seatsCount)
        {
            break;
        }
    }

    totalTickets += soldTickets;
    Console.WriteLine($"{movieName} - {(double)soldTickets / seatsCount * 100:f2}% full.");
}

Console.WriteLine($"Total tickets: {totalTickets}");
Console.WriteLine($"{(double)studentTickets / totalTickets * 100:f2}% student tickets.");
Console.WriteLine($"{(double)standardTickets / totalTickets * 100:f2}% standard tickets.");
Console.WriteLine($"{(double)kidTickets / totalTickets * 100:f2}% kids tickets.");