using System;

class Program
{
    private static void Main()
    {
        long n = long.Parse(Console.ReadLine());
        long[] data = new long[n];

        for (int i = 0; i < n; i++)
        {
            data[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine($"{GCD(data)}\n{LCM(data)}");
    }

    private static long GCD(long[] datas)
    {
        long gcd = datas[0];

        for (int i = 1; i < datas.Length; i++)
        {
            gcd = GCD(gcd, datas[i]);
        }
        return gcd;
    }

    private static long LCM(long[] datas)
    {
        long lcm = datas[0];

        for (int i = 1; i < datas.Length; i++)
        {
            lcm = LCM(lcm, datas[i]);
        }
        return lcm;
    }

    private static long GCD(long a, long b) => b == 0 ? a : GCD(b, a % b);

    private static long LCM(long a, long b) => a * b / GCD(a, b);
}