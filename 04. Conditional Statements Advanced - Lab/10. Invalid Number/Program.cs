//Числото е валидно ако е в интервала [100…200] или е 0

int num = int.Parse(Console.ReadLine());

bool isValid = (num >= 100 && num <= 200) || num == 0;

Console.WriteLine($"isValid -> {isValid}");
Console.WriteLine($"!isValid -> {!isValid}");