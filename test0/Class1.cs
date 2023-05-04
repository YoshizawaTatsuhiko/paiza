using System;
using System.Collections.Generic;

class Program
{
    private static Dictionary<int, int> _divisor = new Dictionary<int, int>();

    static void Main()
    {
        int data = int.Parse(Console.ReadLine());
        int ans = 0;

        for (int i = 0; i < data; i++)
        {
            if (i == 0) ans = int.Parse(Console.ReadLine());
            else
            {
                int n = int.Parse(Console.ReadLine());
                ans = GCD(ans, n);
            }
        }
        Console.WriteLine(ans);
    }

    static int GCD(int a, int b)
    {
        if (a < b) GCD(b, a);

        while (b != 0)
        {
            int remainder = a % b;
            a = b;
            b = remainder;
        }
        return a;
    }
}