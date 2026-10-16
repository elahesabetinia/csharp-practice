Console.Write("Enter a password: ");
string password = Console.ReadLine() ?? "";

CheckPassword(password);

static void CheckPassword(string password)
{
    bool hasUpper = false;
    bool hasLower = false;
    bool hasDigit = false;
    bool hasSymbol = false;

    foreach (char c in password)
    {
        if (char.IsUpper(c)) hasUpper = true;
        else if (char.IsLower(c)) hasLower = true;
        else if (char.IsDigit(c)) hasDigit = true;
        else if (!char.IsWhiteSpace(c)) hasSymbol = true;
    }

    bool longEnough = password.Length >= 8;

    int score = 0;
    if (longEnough) score++;
    if (hasUpper) score++;
    if (hasLower) score++;
    if (hasDigit) score++;
    if (hasSymbol) score++;

    if (!longEnough) Console.WriteLine("- Too short (min 8 characters)");
    if (!hasUpper) Console.WriteLine("- Add an uppercase letter");
    if (!hasLower) Console.WriteLine("- Add a lowercase letter");
    if (!hasDigit) Console.WriteLine("- Add a digit");
    if (!hasSymbol) Console.WriteLine("- Add a symbol (e.g. !@#$)");

    if (score == 5)
        Console.WriteLine("Strong password.");
    else if (score >= 3)
        Console.WriteLine("Medium password.");
    else
        Console.WriteLine("Weak password.");
}