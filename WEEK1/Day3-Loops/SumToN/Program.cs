Console.Write("Enter a number N to sum 1 to N: ");

if (!int.TryParse(Console.ReadLine(), out int number))
{
    Console.WriteLine("Please enter a valid number.");
    return;
}

int sum = 0;
for (int i = 1; i <= number; i++)
{
    sum += i;
}

Console.WriteLine($"Sum with loop:    {sum}");
Console.WriteLine($"Sum with formula: {number * (number + 1) / 2}");