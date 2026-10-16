Console.Write("What factorial do you need? ");

if (!int.TryParse(Console.ReadLine(), out int number))
{
    Console.WriteLine("Please enter a valid number.");
    return;
}

if (number < 0)
{
    Console.WriteLine("Factorial is not defined for negative numbers.");
    return;
}

long result = 1;
for (int i = 1; i <= number; i++)
{
    result = result * i;
}

Console.WriteLine($"{number}! = {result}");