int n = int.Parse(Console.ReadLine());

int num = 1; // 2 на степен 0

for (int i = 0; i <= n; i += 2)
{
    Console.WriteLine(num);
    //num = num * 2 * 2;
    num*=4;
}