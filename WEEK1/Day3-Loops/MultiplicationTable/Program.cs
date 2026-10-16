Console.Write("Enter a number to create a multiplication table: ");

if (!int.TryParse(Console.ReadLine(), out int number))
{
    Console.WriteLine("Please enter a valid number.");
    return;
}

for (int i = 1; i <= 10; i++)
{
    Console.WriteLine($"{number} x {i} = {number * i}");
}