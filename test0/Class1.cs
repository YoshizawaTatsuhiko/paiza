using System;

public class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int max = int.MinValue;

        for (int i = 1; i < n; i++)
        {
            for (int j = i + 1; j <= n; j++)
            {
                int d = GCD(i, j);

                if(max < d) max = d;
            }
        }
        Console.WriteLine(max);
    }

    static int GCD(int a, int b)
    {
        if (b == 0) return a;
        return GCD(b, a % b);
    }
}