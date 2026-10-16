Console.Write("Enter a sentence: ");
string sentence = Console.ReadLine() ?? "";

Console.WriteLine($"Words: {CountWords(sentence)}");

static int CountWords(string sentence)
{
    string[] words = sentence.Split(' ', StringSplitOptions.RemoveEmptyEntries);
    return words.Length;
}