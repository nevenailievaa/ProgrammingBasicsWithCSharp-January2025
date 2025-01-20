//Monday   Tuesday	Wednesday	Thursday	Friday	Saturday	Sunday
//  12	     12	        14	        14	      12	    16	      16

string day = Console.ReadLine();

/*if (day == "Monday" || day == "Tuesday" || day == "Friday")
     ticketPrice = 12;
else if (day == "Wednesday" || day == "Thursday")
    ticketPrice = 14;
else if (day == "Saturday" || day == "Sunday")
    ticketPrice = 16;*/

switch (day)
{
    case "Monday":
    case "Tuesday":
    case "Friday":
        Console.WriteLine(12);
        break;
    case "Wednesday":
    case "Thursday":
        Console.WriteLine(14);
        break;
    case "Saturday":
    case "Sunday":
        Console.WriteLine(16);
        break;
}
