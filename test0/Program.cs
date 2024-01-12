using System;

class Program
{
    private static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        long[] fiboArray = new long[n + 1];
        fiboArray[0] = 0;
        fiboArray[1] = 1;

        for (int i = 2; i <= n; i++)
        {
            fiboArray[i] = (fiboArray[i - 1] + fiboArray[i - 2]) % 1000000007;
        }
        Console.WriteLine(fiboArray[fiboArray.Length - 1]);
    }
}
