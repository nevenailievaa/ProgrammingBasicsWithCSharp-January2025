int num = int.Parse(Console.ReadLine());

//под 100 => "Less than 100"
//между 100 и 200 => "Between 100 and 200"
//над 200 => "Greater than 200"

if (num < 100)
    Console.WriteLine("Less than 100");
else if (num <= 200)
    Console.WriteLine("Between 100 and 200");
else
    Console.WriteLine("Greater than 200");