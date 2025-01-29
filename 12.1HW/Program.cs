using System;

Console.Write("Введіть номер числа Фібоначчі: ");
int n = int.Parse(Console.ReadLine());

int result = Fibonacci.FibonacciCalculator(n);
Console.WriteLine($"Число Фібоначчі номер {n}: {result}");

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
