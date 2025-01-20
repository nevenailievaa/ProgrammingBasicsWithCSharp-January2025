//Плодове: banana, apple, kiwi, cherry, lemon, grapes
//Зеленчуци: tomato, cucumber, pepper, carrot
//Извежда "vegetable","fruit" или "unknown"

string input = Console.ReadLine();

switch (input)
{
	case "banana":
	case "apple":
	case "kiwi":
	case "cherry":
	case "lemon":
	case "grapes":
        Console.WriteLine("fruit");
		break;
	case "tomato":
	case "cucumber":
	case "pepper":
	case "carrot":
		Console.WriteLine("vegetable");
		break;
    default:
        Console.WriteLine("unknown");
        break;
}

