//Input
int tabsOpened = int.Parse(Console.ReadLine());
int salary = int.Parse(Console.ReadLine());

//Calculations
for (int i = 1; i <= tabsOpened; i++)
{
    string website = Console.ReadLine();

    if (website == "Facebook")
    {
        salary -= 150;
    }
    else if (website == "Instagram")
    {
        salary -= 100;
    }
    else if (website == "Reddit")
    {
        salary -= 50;
    }

    //Output
    if (salary <= 0)
    {
        Console.WriteLine("You have lost your salary.");
        break;
    }
}

//Output
if (salary > 0)
{
    Console.WriteLine(salary);
}