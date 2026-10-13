Console.WriteLine("Enter a Number to see if it's Odd or Even:");
string num = Console.ReadLine();

if (int.TryParse(num, out int number))
{
    if (number % 2 == 0)
        Console.WriteLine($"{number} is Even.");
    else
        Console.WriteLine($"{number} is Odd.");
}
else
{
    Console.WriteLine("Please try a valid number.");
}
