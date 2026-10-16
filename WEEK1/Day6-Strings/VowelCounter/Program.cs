Console.Write("Enter a text: ");
string text = Console.ReadLine() ?? "";

Console.WriteLine($"Vowels: {CountVowels(text)}");

static int CountVowels(string text)
{
    int count = 0;
    string vowels = "aeiou";

    foreach (char c in text.ToLower())
    {
        if (vowels.Contains(c))
            count++;
    }
    return count;
}