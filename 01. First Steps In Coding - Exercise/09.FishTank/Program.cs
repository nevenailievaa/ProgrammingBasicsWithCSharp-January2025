//Input
int length = int.Parse(Console.ReadLine());
int width = int.Parse(Console.ReadLine());
int height = int.Parse(Console.ReadLine());
double percent = double.Parse(Console.ReadLine()) / 100;

//Calculations
int aquariumVolume = length * width * height; // In Cubic Centimeters
double aquariumLitersVolume = aquariumVolume / 1000.0; // In Cubic Decimeters
double takenSpace = aquariumLitersVolume * percent; // In Cubic Decimeters

double neededLiters = aquariumLitersVolume - takenSpace;

//Output
Console.WriteLine(neededLiters);