Console.Write("How many terms? ");

if (!int.TryParse(Console.ReadLine(), out int n) || n < 1)
{
    Console.WriteLine("Please enter a positive number.");
    return;
}

PrintFibonacci(n);

Console.WriteLine($"Term {n} = {Fib(n)}");

static void PrintFibonacci(int n)
{
    long a = 0, b = 1;

    for (int i = 0; i < n; i++)
    {
        Console.Write(a + " ");
        long next = a + b;
        a = b;
        b = next;
    }
    Console.WriteLine();
}

static long Fib(int n)
{
    long a = 0, b = 1;

    for (int i = 1; i < n; i++)
    {
        long next = a + b;
        a = b;
        b = next;
    }
    return a;
}
