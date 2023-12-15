using System;

class Program
{
    private static void Main()
    {
        int[] datas = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        Console.WriteLine(GCD(datas[0], datas[1]));
    }

    private static int GCD(int a, int b) => b == 0 ? a : GCD(b, a % b);
}