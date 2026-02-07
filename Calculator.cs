using System;

public class Calculator
{
    public static double? PerformOperation(int num1, int num2, string operation)
    {
        switch (operation)
        {
            case "+":
                return num1 + num2;
            case "-":
                return num1 - num2;
            case "*":
                return num1 * num2;
            case "/":
                if (num2 == 0)
                {
                    Console.WriteLine("Cannot divide by zero.");
                    return null;
                }
                return (double)num1 / num2;
            case "%":
                if (num2 == 0)
                {
                    Console.WriteLine("Cannot modulo by zero.");
                    return null;
                }
                return num1 % num2;
            default:
                Console.WriteLine("Incorrect Operation Used, please try again");
                return null;
        }
    }
}
