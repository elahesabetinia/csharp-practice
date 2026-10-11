using System;

namespace MyCalculator
{
    class Program
    {
        static void Main()
        {
            do
            {
                Console.Clear();
                RunCalculator();
            } while (AskToContinue());

            Console.WriteLine("Goodbye!");
        }

        static void RunCalculator()
        {
            double a = GetNumber("Enter first number: ");

            Console.Write("Enter operator (+, -, *, /, %): ");
            string op = Console.ReadLine();

            double b = GetNumber("Enter second number: ");

            double result;

            switch (op)
            {
                case "+":
                    result = a + b;
                    break;
                case "-":
                    result = a - b;
                    break;
                case "*":
                    result = a * b;
                    break;
                case "/":
                    if (b == 0)
                    {
                        Console.WriteLine("Error: cannot divide by zero.");
                        return;
                    }
                    result = a / b;
                    break;
                case "%":
                    if (b == 0)
                    {
                        Console.WriteLine("Error: cannot modulo by zero.");
                        return;
                    }
                    result = a % b;
                    break;
                default:
                    Console.WriteLine("Invalid operator.");
                    return;
            }

            Console.WriteLine($"\n{a} {op} {b} = {result}");
        }

        static double GetNumber(string prompt)
        {
            double number;
            Console.Write(prompt);
            while (!double.TryParse(Console.ReadLine(), out number))
            {
                Console.Write("Invalid number! Try again: ");
            }
            return number;
        }

        static bool AskToContinue()
        {
            Console.Write("\nDo you want to continue? (y/n): ");
            string answer = Console.ReadLine()?.Trim().ToLower();
            return answer == "y" || answer == "yes";
        }
    }
}