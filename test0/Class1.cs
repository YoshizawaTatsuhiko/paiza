using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        long n = long.Parse(Console.ReadLine());
        Console.WriteLine(IsPrime(n) ? "YES" : "NO");
    }

    static bool IsPrime(long n)
    {
        if(n <= 1) return false;
        if(n == 2) return true;
        if(n % 2 == 0) return false;

        for (int i = 3; i <= Math.Sqrt(n); i += 2)
        {
            if (n % i == 0) return false;
        }
        return true;
    }
}