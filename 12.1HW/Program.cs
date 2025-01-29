using System;

static class Fibonacci
{
    public static int FibonacciCalculator(int n)
    {
        if (n <= 1)
        {
            return n;
        }
        return FibonacciCalculator(n - 1) + FibonacciCalculator(n - 2);

    }
}