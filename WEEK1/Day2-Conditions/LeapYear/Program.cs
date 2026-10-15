Console.Write("Enter a year: ");

if (!int.TryParse(Console.ReadLine(), out int year))
{
    Console.WriteLine("Please enter a valid year.");
    return;
}

bool isLeap = (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);

if (isLeap)
    Console.WriteLine($"{year} is a leap year.");
else
    Console.WriteLine($"{year} is not a leap year.");