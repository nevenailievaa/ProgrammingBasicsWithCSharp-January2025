int stepsCount = 0;

while (stepsCount < 10000)
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

if (stepsCount >= 10000)
{
    int stepsOverGoal = stepsCount - 10000;

    Console.WriteLine("Goal reached! Good job!");
    Console.WriteLine($"{stepsOverGoal} steps over the goal!");
}
else
{
    int stepsToGoal = 10000 - stepsCount;

    Console.WriteLine($"{stepsToGoal} more steps to reach goal.");
}