using System;

class Program
{
    static void Main()
    {
        int data = int.Parse(Console.ReadLine());
        double ans = 0;

        for (int i = 0; i < data; i++)
        {
            if (i == 0) ans = double.Parse(Console.ReadLine());
            else
            {
                double n = double.Parse(Console.ReadLine());
                ans = LCM(ans, n);
            }
        }
        Console.WriteLine(ans);
    }

    static double GCD(double a, double b)
    {
        if (a < b) return GCD(b, a);

        while (b != 0)
        {
            double remainder = a % b;
            a = b;
            b = remainder;
        }
        return a;
    }

    static double LCM(double a, double b)
    {
        return a * b / GCD(a, b);
    }
}