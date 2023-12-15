using System;

class Program
{
    private static void Main()
    {
        long[] datas = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
        Console.WriteLine(LCM(datas[0], datas[1]));
    }

    private static long GCD(long a, long b) => b == 0 ? a : GCD(b, a % b);

    private static long LCM(long a, long b) => a * b / GCD(a, b);
}