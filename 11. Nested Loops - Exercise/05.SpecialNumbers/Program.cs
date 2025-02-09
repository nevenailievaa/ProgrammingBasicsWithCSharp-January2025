//Input
int n = int.Parse(Console.ReadLine());

//Calculations
for (int currentNum = 1111; currentNum <= 9999; currentNum++)
{
    string currentNumAsString = currentNum.ToString();
    bool isSpecial = true;

    for (int symbolPosition = 0; symbolPosition <= currentNumAsString.Length; symbolPosition++)
    {
        int currentDigit = int.Parse(currentNumAsString[symbolPosition].ToString());

        if (currentDigit == 0 || n % currentDigit != 0)
        {
            isSpecial = false;
            break;
        }
    }

    //Output
    if (isSpecial)
    {
        Console.Write(currentNum + " ");
    }
}