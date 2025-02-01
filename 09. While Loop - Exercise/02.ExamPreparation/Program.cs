int poorGradesLimit = int.Parse(Console.ReadLine());

int problemsCount = 0;
int poorGradesCount = 0;
int allGradesSum = 0;
string lastProblem = "";

string problemName = Console.ReadLine();

while (problemName != "Enough")
{
    int currentGrade = int.Parse(Console.ReadLine());
    problemsCount++;
    allGradesSum += currentGrade;
    lastProblem = problemName;

    if (currentGrade <= 4)
    {
        poorGradesCount++;

        if (poorGradesCount == poorGradesLimit)
        {
            Console.WriteLine($"You need a break, {poorGradesLimit} poor grades.");
            break;
        }
    }

    problemName = Console.ReadLine();
}

if (poorGradesCount < poorGradesLimit)
{
    double averageGrade = (double)allGradesSum / problemsCount;

    Console.WriteLine($"Average score: {averageGrade:F2}");
    Console.WriteLine($"Number of problems: {problemsCount}");
    Console.WriteLine($"Last problem: {lastProblem}");
}