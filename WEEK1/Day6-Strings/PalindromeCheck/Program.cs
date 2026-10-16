Console.Write("Enter a text: ");
string text = Console.ReadLine() ?? "";

if (IsPalindrome(text))
    Console.WriteLine("It is a palindrome.");
else
    Console.WriteLine("It is not a palindrome.");

static bool IsPalindrome(string text)
{
    string cleaned = "";

    foreach (char c in text)
    {
        if (char.IsLetterOrDigit(c))
            cleaned += char.ToLower(c);
    }

    int left = 0;
    int right = cleaned.Length - 1;

    while (left < right)
    {
        if (cleaned[left] != cleaned[right])
            return false;
        left++;
        right--;
    }
    return true;
}