//парола: "s3cr3t!P@ssw0rd"
//При съвпадение => "Welcome"
//При несъвпадение => "Wrong password!"

string password = Console.ReadLine();

if (password == "s3cr3t!P@ssw0rd")
    Console.WriteLine("Welcome");
else
    Console.WriteLine("Wrong password!");