using System;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Simple Calculator");
            char operation = ValidOperation();// Get the operation from users
            double num1 = ValidNumber("\nEnter the first number: ");// Get the first number from users
            double num2 = ValidNumber("\nEnter the second number: ", operation == '/');// Get the second number from users
            double result = Calculate(operation, num1, num2);

            Console.WriteLine($"\nResult: {result}");
            Console.ReadKey();
        }

        // Method to get a valid operation from users
        static char ValidOperation()
        {
            char operation;
            do
            {
                Console.Write("\nEnter operation (+, -, *, /): ");
                string input = Console.ReadLine();
                if (input.Length == 1 && "+-*/".Contains(input[0]))// Check if the input is a valid operation
                {
                    operation = input[0];
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid operation. Please enter one of (+, -, *, /).");
                }
            } 
            while (true);
            return operation;
        }

        // Method to get a valid number from users
        static double ValidNumber(string prompt, bool preventZero = false)// Prevent division by zero
        {
            double num;
            do
            {
                Console.Write(prompt);
                string input = Console.ReadLine();
                if (double.TryParse(input, out num))// Check if the input is a valid number
                {
                    if (preventZero && num == 0)// Avoid division by zero
                    {
                        Console.WriteLine("Error! Cannot divide by zero.");
                    }
                    else
                    {
                        break;// Exit the loop if the input is a valid number
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input! Please enter a valid number.");
                }
            } 
            while (true);// Continue the loop until a valid number is entered
            return num;
        }

        // Method to perform the calculation based on the operation
        static double Calculate(char operation, double num1, double num2)// Calculate the result based on the operation
        {
            switch (operation)
            {
                case '+':
                    return num1 + num2;
                case '-':
                    return num1 - num2;
                case '*':
                    return num1 * num2;
                case '/':
                    if (num2 == 0)// Check if the denominator is zero
                    {
                        Console.WriteLine("Error! Division by zero.");
                        return 0;
                    }
                    return num1 / num2;
                default:
                    Console.WriteLine("Invalid operation.");
                    return 0;
            }
        }
    }
}