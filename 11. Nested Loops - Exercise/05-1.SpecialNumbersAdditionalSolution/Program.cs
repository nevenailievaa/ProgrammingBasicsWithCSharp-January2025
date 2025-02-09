//Input
int n = int.Parse(Console.ReadLine());

//Calculations
for (int currentNum = 1111; currentNum <= 9999; currentNum++)
{
    bool isSpecial = true;
    int num = currentNum;

    for (int i = 1; i <= 4; i++) //Because the digits count of the nums from 1111 to 9999 is always 4
    {
        int currentDigit = num % 10;
        if (currentDigit == 0 || n % currentDigit != 0)
        {
            isSpecial = false;
            break;
        }

        num = (num - currentDigit) / 10;
    }

    //Output
    if (isSpecial)
    {
        Console.Write(currentNum + " ");
    }
}