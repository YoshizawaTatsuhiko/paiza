using System;

class Program
{
    private static void Main()
    {
        int[] data = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        Console.WriteLine(LCM(data[0], data[1]));
    }

    private static long GCD(long a, long b) => b == 0 ? a : GCD(b, a % b);

    private static long LCM(long a, long b) => a * b / GCD(a, b);
}