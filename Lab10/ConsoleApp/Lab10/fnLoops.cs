using System;

class LoopFunctionDemo
{
    public static void PrintNumbers()
    {
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(i);
        }
    }

    public static int Factorial(int n)
    {
        if (n == 0 || n == 1) return 1;
        return n * Factorial(n - 1);
    }

}