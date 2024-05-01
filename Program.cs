using System;

class Program
{
    static void Main(string[] args)
    {
        bool exit = false;

        while (!exit)
        {
            Console.WriteLine("Calculator Menu:");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");
            Console.WriteLine("5. Exit");

            Console.Write("Enter the operation you wish to do: ");
            int choice = int.Parse(Console.ReadLine());
            // These lines are used to switch between the operations          
            switch (choice)
            {
                case 1:
                    Addition();
                    break;
                case 2:
                    Subtraction();
                    break;
                case 3:
                    Multiplication();
                    break;
                case 4:
                    Division();
                    break;
                case 5:
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please enter a number between 1 and 5.");
                    break;
            }

            Console.WriteLine();
        }
    }
// +
    static void Addition()
    {
        Console.Write("Enter first number: ");
        double num1 = double.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        double num2 = double.Parse(Console.ReadLine());
        Console.WriteLine($"Result: {num1} + {num2} = {num1 + num2}");
    }
// -
    static void Subtraction()
    {
        Console.Write("Enter first number: ");
        double num1 = double.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        double num2 = double.Parse(Console.ReadLine());
        Console.WriteLine($"Result: {num1} - {num2} = {num1 - num2}");
    }
// x
    static void Multiplication()
    {
        Console.Write("Enter first number: ");
        double num1 = double.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        double num2 = double.Parse(Console.ReadLine());
        Console.WriteLine($"Result: {num1} * {num2} = {num1 * num2}");
    }
// /
    static void Division()
    {
        Console.Write("Enter dividend: ");
        double dividend = double.Parse(Console.ReadLine());
        Console.Write("Enter divisor: ");
        double divisor = double.Parse(Console.ReadLine());
        
        {
            Console.WriteLine($"Result: {dividend} / {divisor} = {dividend / divisor}");
        }
       
    }
}
