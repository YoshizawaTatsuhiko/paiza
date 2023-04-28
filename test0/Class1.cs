using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int n = 57;
        bool isPrime = true;

        for (int i = 3; i <= Math.Sqrt(n); i += 2)
        {
            if (n % i == 0)
            {
                isPrime = false;
                break;
            }
        }
        Console.WriteLine(isPrime ? "YES" : "NO");
    }
}