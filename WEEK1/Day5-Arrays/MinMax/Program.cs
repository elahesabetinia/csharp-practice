Console.Write("How many numbers? ");

if (!int.TryParse(Console.ReadLine(), out int count) || count < 1)
{
    Console.WriteLine("Please enter a positive number.");
    return;
}

int[] numbers = new int[count];

for (int i = 0; i < count; i++)
{
    Console.Write($"Enter number {i + 1}: ");
    while (!int.TryParse(Console.ReadLine(), out numbers[i]))
    {
        Console.Write("Invalid! Try again: ");
    }
}

int max = FindMax(numbers);
int min = FindMin(numbers);

Console.WriteLine($"Max = {max}, Min = {min}");

static int FindMax(int[] arr)
{
    int max = arr[0];

    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] > max)
            max = arr[i];
    }
    return max;
}

static int FindMin(int[] arr)
{
    int min = arr[0];

    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] < min)
            min = arr[i];
    }
    return min;
}