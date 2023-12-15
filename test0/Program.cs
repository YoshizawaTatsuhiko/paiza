using System;

class Program
{
    private static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int data = int.Parse(Console.ReadLine());

        for (int i = 1; i < n; i++)
        {
            data = GCD(data, int.Parse(Console.ReadLine()));
        }
        Console.WriteLine(data);
    }

    private static int GCD(int a, int b) => b == 0 ? a : GCD(b, a % b);
}