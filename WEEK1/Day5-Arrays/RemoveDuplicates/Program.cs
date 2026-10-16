List<int> numbers = new List<int>();

Console.WriteLine("Enter numbers separated by space (e.g. 1 2 2 3 3 3):");
string input = Console.ReadLine() ?? "";
string[] parts = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

foreach (string part in parts)
{
    if (int.TryParse(part, out int value))
        numbers.Add(value);
    else
        Console.WriteLine($"Skipped invalid value: {part}");
}

List<int> unique = RemoveDuplicates(numbers);

Console.WriteLine("Before: " + string.Join(", ", numbers));
Console.WriteLine("After:  " + string.Join(", ", unique));

static List<int> RemoveDuplicates(List<int> list)
{
    List<int> result = new List<int>();

    foreach (int item in list)
    {
        if (!result.Contains(item))
            result.Add(item);
    }
    return result;
}