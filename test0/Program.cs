using System;

class Program
{
    private static void Main()
    {
        string[] datas = Console.ReadLine().Split();
        int a = int.Parse(datas[0]);
        int b = int.Parse(datas[1]);
        string cal = datas[2];
        int c = int.Parse(datas[3]);
        int d = int.Parse(datas[4]);
        int numerator = 0;
        int denominator = 0;


        switch (cal)
        {
            case "+":
                numerator = a * d + c * b;
                denominator = b * d;
                break;
            case "-":
                numerator = a * d - c * b;
                denominator = b * d;
                break;
            case "*":
                numerator = a * c;
                denominator = b * d;
                break;
            case "/":
                numerator = a * d;
                denominator = b * c;
                break;
        }
        var ans = Simplify(numerator, denominator);

        if (ans.Item2 < 0) Console.WriteLine($"{-ans.Item1} {-ans.Item2}");
        else Console.WriteLine($"{ans.Item1} {ans.Item2}");
    }

    private static int GCD(int a, int b) => b == 0 ? a : GCD(b, a % b);

    private static Tuple<int, int> Simplify(int n, int d)
    {
        int gcd = GCD(n, d);
        if(gcd == 1) return Tuple.Create(n, d);

        n /= gcd;
        d /= gcd;
        return Simplify(n, d);
    }
}