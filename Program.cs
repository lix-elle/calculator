using System;

public class Program
{
    static void Main()
    {
        while(true)
        {
            Console.WriteLine("Enter first number: ");
            int num1;
            while (!int.TryParse(Console.ReadLine(), out num1))
            {
                Console.WriteLine("Please enter a valid whole number.");
                Console.WriteLine("Enter first number: ");
            }
            
            Console.WriteLine("Enter second number: ");
            int num2;
            while (!int.TryParse(Console.ReadLine(), out num2))
            {
                Console.WriteLine("Please enter a valid whole number.");
                Console.Writeline("Enter second number: ");
            }
            
            
            string operation;
            while (true)
            {
                Console.WriteLine("Choose operation (+, -, *, /, %, =): ");
                operation = Console.ReadLine();

                if (operation == "=")
                {
                    Console.WriteLine("Exiting the program.");
                    return;
                }

                if (operation == "+" || operation == "-" || operation == "*" || operation == "/" || operation == "%")
                {
                    break;
                }

                Console.WriteLine("Incorrect Operation Used, please try again.");
            }

            double? result = Calculator.PerformOperation(num1, num2, operation);

            if (result == null)
            {
                continue;
            }

            Console.WriteLine("Result: " + result);

            Console.WriteLine();

        }
    }
}
