Console.WriteLine("What's Yuor Name?");
string name = Console.ReadLine();

Console.WriteLine("Your Age?");
int age = int.Parse(Console.ReadLine());

Console.WriteLine($"Hi {name},You are {age}!");
Console.ReadKey();