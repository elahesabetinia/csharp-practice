Console.Write("Enter a word: ");
string text = Console.ReadLine() ?? "";

string reversed = Reverse(text);
Console.WriteLine($"Reversed: {reversed}");

if (IsPalindrome(text))
    Console.WriteLine("It is a palindrome.");
else
    Console.WriteLine("It is not a palindrome.");

static string Reverse(string text)
{
    string result = "";

    for (int i = text.Length - 1; i >= 0; i--)
    {
        result += text[i];
    }
    return result;
}

static bool IsPalindrome(string text)
{
    string cleaned = text.ToLower();
    return cleaned == Reverse(cleaned);
}