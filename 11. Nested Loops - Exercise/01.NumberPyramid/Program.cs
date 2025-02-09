//Input
int n = int.Parse(Console.ReadLine());

//Pyramid Print
int currentNumber = 0;

for (int row = 1; row <= n; row++)
{
    for (int col = 1; col <= row; col++)
    {
        currentNumber++;

        if (currentNumber > n)
        {
            break;
        }

        //Output
        Console.Write(currentNumber + " ");
    }

    if (currentNumber > n)
    {
        break;
    }

    Console.WriteLine(); //Next Row
}