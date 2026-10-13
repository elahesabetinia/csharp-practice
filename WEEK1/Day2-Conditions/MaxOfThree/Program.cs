Console.WriteLine("Let's see which of the 3 numbers is bigger...");

Console.WriteLine("Enter the first number:");
int num1 = int.Parse(Console.ReadLine());

Console.WriteLine("Enter the second number:");
int num2 = int.Parse(Console.ReadLine());

Console.WriteLine("Enter the 3rd number:");
int num3 = int.Parse(Console.ReadLine());

int max = num1;
if (num2 > max) max = num2;
if (num3 > max) max = num3;

int count = 0;
if (num1 == max) count++;
if (num2 == max) count++;
if (num3 == max) count++;

if (count == 3)
{
    Console.WriteLine("All three numbers are equal.");
}
else if (count == 2)
{
    Console.WriteLine($"{max} is the biggest, and it appears twice.");
}
else
{
    Console.WriteLine($"{max} is the biggest number.");
}