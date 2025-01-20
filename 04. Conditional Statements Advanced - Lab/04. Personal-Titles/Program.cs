double age = double.Parse(Console.ReadLine());
char gender = char.Parse(Console.ReadLine());

if (gender == 'm')
{
    //"Mr." – мъж(пол 'm') на 16 или повече години
    //"Master" – момче (пол 'm') под 16 години
    if (age >= 16)
        Console.WriteLine("Mr.");
    else
        Console.WriteLine("Master");
}
else
{
    //"Ms." – жена (пол 'f') на 16 или повече години
    //"Miss" – момиче (пол 'f') под 16 години
    if (age >= 16)
        Console.WriteLine("Ms.");
    else
        Console.WriteLine("Miss");
}