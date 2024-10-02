using System;
using System.Linq.Expressions;
namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Simple Calculator");
            Console.Write("Enter operation (+, -, *, /): ");
            char operation = Convert.ToChar(Console.ReadLine());
            bool validOperation = false;
            while (!validOperation)
            {
                if (operation == '+' || operation == '-' || operation == '*' || operation == '/')
                {
                    validOperation = true;
                }
                else
                {
                    Console.WriteLine("\nInvalid operation. Please enter a valid operation (+, -, *, /)");
                    Console.Write("Enter operation: ");
                    operation = Convert.ToChar(Console.ReadLine());
                }
            }
            double num1, num2;
            Console.Write("\nEnter the first number: ");
            while (!double.TryParse(Console.ReadLine(), out num1))
            {
                Console.WriteLine("\nInvalid input! Please enter a valid number.");
                Console.Write("Enter the first number: ");
            }
            Console.Write("\nEnter the second number: ");
            while (!double.TryParse(Console.ReadLine(), out num2))
            {
                Console.WriteLine("\nInvalid input! Please enter a valid number.");
                Console.Write("Enter the second number: ");
            }
            double result;
            switch (operation)
            {
                case '+':
                    result = num1 + num2;
                    break;

                case '-':
                    result = num1 - num2;
                    break;

                case '*':
                    result = num1 * num2;
                    break;

                case '/':
                    while (num2 == 0)
                    {
                        Console.WriteLine("\nError! Cannot divide by zero.");
                        Console.Write("Enter the second number (not zero): ");
                        num2 = Convert.ToDouble(Console.ReadLine());
                    }
                    result = num1 / num2;
                    break; 

                default:
                    Console.WriteLine("Invalid operation");
                    return;
            }
            Console.WriteLine($"Result: {result}");
            Console.ReadLine();
        }
    }
}
