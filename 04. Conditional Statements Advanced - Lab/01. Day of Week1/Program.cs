//1 Monday
//2	Tuesday
//3	Wednesday
//4	Thursday
//5	Friday
//6	Saturday
//7	Sunday
//-1 Error


int num = int.Parse(Console.ReadLine());

switch (num)
{
	case 1: Console.WriteLine("Monday"); break; 
    case 2: Console.WriteLine("Tuesday"); break;
    case 3: Console.WriteLine("Wednesday"); break;
    case 4: Console.WriteLine("Thursday"); break;
    case 5: Console.WriteLine("Friday"); break;
    case 6: Console.WriteLine("Saturday"); break;
    case 7: Console.WriteLine("Sunday"); break;
    default: Console.WriteLine("Error"); break;
} 

/*
if (num == 1)
    Console.WriteLine("Monday");
else if (num == 2)
    Console.WriteLine("Tuesday");
else if (num == 3)
    Console.WriteLine("Wednesday");
else if (num == 4)
    Console.WriteLine("Thursday");
else if (num == 5)
    Console.WriteLine("Friday");
else if (num == 6)
    Console.WriteLine("Saturday");
else if (num == 7)
    Console.WriteLine("Sunday");
else
    Console.WriteLine("Error");
*/