using System;
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
            Console.WriteLine("\nEnter the first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\nEnter the second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double result = 0;
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
                    result = num1 / num2;
                    break;
                default:
                    Console.WriteLine("Invalid operation");
                    return;
            }
            Console.WriteLine($"Result: {result}");
            Console.ReadKey();
        }
    }
}
