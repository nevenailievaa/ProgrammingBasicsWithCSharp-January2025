//[-100, 100] и е различно от 0 => "Yes" или "No", ако не отговаря

int num = int.Parse(Console.ReadLine());

if (num >= -100 && num <= 100 && num != 0)
    Console.WriteLine("Yes");
else
    Console.WriteLine("No");

