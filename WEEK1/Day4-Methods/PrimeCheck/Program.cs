Console.Write("Enter a number: ");

if (!int.TryParse(Console.ReadLine(), out int number))
{
    Console.WriteLine("Please enter a valid number.");
    return;
}

if (IsPrime(number))
    Console.WriteLine($"{number} is prime.");
else
    Console.WriteLine($"{number} is not prime.");

Console.WriteLine("\nPrimes from 1 to 100:");
for (int i = 1; i <= 100; i++)
{
    if (IsPrime(i))
        Console.Write(i + " ");
}
Console.WriteLine();

static bool IsPrime(int n)
{
    if (n < 2) return false;
    if (n == 2) return true;
    if (n % 2 == 0) return false;

    for (int i = 3; i * i <= n; i += 2)
    {
        if (n % i == 0)
            return false;
    }
    return true;
}