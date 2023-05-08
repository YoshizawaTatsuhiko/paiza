using System;

class Program
{
    static void Main()
    {
        int[] data = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        double m1 = data[0], m2 = data[1];
        int b1 = data[2], b2 = data[3];
        double ans = 0;

        for (double i = 0; i < m1 * m2; i++)
        {
            ans = m1 * i + b1;

            if (ans % m2 == b2) break;
        }
        Console.WriteLine(ans);
    }
}