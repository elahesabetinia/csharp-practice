Console.Write("Enter the height: ");

if (!int.TryParse(Console.ReadLine(), out int height) || height < 1)
{
    Console.WriteLine("Please enter a valid positive number.");
    return;
}
//Triangle
for (int i = 1; i <= height; i++)
{
    for (int j = 1; j <= i; j++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}
//Inverted Triangle
for (int i = height; i >= 1; i--)  
{
    for (int j = 1; j <= i; j++)
        Console.Write("*");
    Console.WriteLine();
}
//Central Triangle
for (int i = 1; i <= height; i++)   
{
    int starCount = height - i + 1; 
    for (int j = 1; j <= starCount; j++)
        Console.Write("*");
    Console.WriteLine();
}
