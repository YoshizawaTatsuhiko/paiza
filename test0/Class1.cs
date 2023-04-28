using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        uint data = uint.Parse(Console.ReadLine());
        bool[] isPrime = new bool[data + 1];

        for (int i = 2; i <= data; i++)
            isPrime[i] = true;

        for (int i = 2; i < data; i++)
        {
            if (isPrime[i] == true)
            {
                for (int k = 2; i * k <= data; k++)
                {
                    if (isPrime[i * k] == true) isPrime[i * k] = false;
                }
            }
        }
        Console.WriteLine(isPrime[data] == true ? "YES" : "NO");
    }
}