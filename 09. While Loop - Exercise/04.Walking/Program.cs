//Calculations
int stepsCount = 0;
int stepsGoal = 10000;

while (stepsCount < stepsGoal)
{
    string input = Console.ReadLine();

    if (input == "Going home")
    {
        int stepsToHome = int.Parse(Console.ReadLine());
        stepsCount += stepsToHome;
        break;
    }

    int currentSteps = int.Parse(input);
    stepsCount += currentSteps;
}

//Output
if (stepsCount >= stepsGoal)
{
    int stepsOverGoal = stepsCount - stepsGoal;
    Console.WriteLine("Goal reached! Good job!");
    Console.WriteLine($"{stepsOverGoal} steps over the goal!");
}
else
{
    int stepsToGoal = stepsGoal - stepsCount;
    Console.WriteLine($"{stepsToGoal} more steps to reach goal.");
}