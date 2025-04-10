using System;

// Define the Calculator class
public class Calculator
{
    public int Add(int num1, int num2)
    {
        return num1 + num2;
    }

    public int Subtract(int num1, int num2)
    {
        return num1 - num2;
    }

    public double Multiply(int num1, int num2)
    {
        return num1 * num2;
    }

    public string Divide(int num1, int num2)
    {
        try
        {
            return (num1 / (double)num2).ToString();
        }
        catch (DivideByZeroException)
        {
            return "Cannot divide by zero";
        }
    }

    public string CheckSumParity(int sum)
    {
        return sum % 2 == 0 ? "The sum is even." : "The sum is odd.";
    }
}