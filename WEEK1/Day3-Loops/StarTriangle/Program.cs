Console.Write("Enter the height: ");

if (!int.TryParse(Console.ReadLine(), out int height) || height < 1)
{
    Console.WriteLine("Please enter a valid positive number.");
    return;
}

for (int i = 1; i <= height; i++)
{
    for (int j = 1; j <= i; j++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}
