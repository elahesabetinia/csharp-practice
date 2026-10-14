Console.Write("Enter your grade (0-20): ");

if (!double.TryParse(Console.ReadLine(), out double grade))
{
    Console.WriteLine("Please enter a valid number.");
    return;
}

if (grade < 0 || grade > 20)
{
    Console.WriteLine("Invalid grade! Must be between 0 and 20.");
    return;
}

if (grade >= 17)
{
    Console.WriteLine("A");
}
else if (grade >= 14)
{
    Console.WriteLine("B");
}
else if (grade >= 11)
{
    Console.WriteLine("C");
}
else if (grade >= 8)
{
    Console.WriteLine("D");
}
else
{
    Console.WriteLine("F");
}