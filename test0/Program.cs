using System;

class Program
{
    private static void Main()
    {
        long n = long.Parse(Console.ReadLine());
        long data = int.Parse(Console.ReadLine()) - 1;

        for (int i = 1; i < n; i++)
        {
            data = LCM(data, int.Parse(Console.ReadLine()) - 1);
        }
        Console.WriteLine(data);
    }

    private static long GCD(long a, long b) => b == 0 ? a : GCD(b, a % b);

    private static long LCM(long a, long b) => a * b / GCD(a, b);
}