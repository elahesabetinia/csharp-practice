Console.Write("How many numbers? ");

if (!int.TryParse(Console.ReadLine(), out int count) || count < 1)
{
    Console.WriteLine("Please enter a positive number.");
    return;
}

double[] numbers = new double[count];

for (int i = 0; i < count; i++)
{
    Console.Write($"Enter number {i + 1}: ");
    while (!double.TryParse(Console.ReadLine(), out numbers[i]))
    {
        Console.Write("Invalid! Try again: ");
    }
}

Console.WriteLine($"Average = {Average(numbers)}");

// چالش: params
Console.WriteLine($"Average(1, 2, 3) = {AverageParams(1, 2, 3)}");

static double Average(double[] numbers)
{
    if (numbers.Length == 0)
        return 0;

    double sum = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        sum += numbers[i];
    }
    return sum / numbers.Length;
}

static double AverageParams(params double[] numbers)
{
    return Average(numbers);
}
