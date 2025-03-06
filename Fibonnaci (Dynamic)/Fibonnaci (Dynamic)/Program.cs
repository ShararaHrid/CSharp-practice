using System;

class FibonacciDP
{
    static long[] dp = new long[100];

    static long Fibonacci(int n)
    {
        if (n <= 1) return n;
        if (dp[n] != 0) return dp[n];

        dp[n] = Fibonacci(n - 1) + Fibonacci(n - 2);
        return dp[n];
    }

    static void Main()
    {
        Console.Write("Enter a number: ");
        int num = int.Parse(Console.ReadLine());
        Console.WriteLine($"Fibonacci({num}) = {Fibonacci(num)}");
    }
}
