using System;

class Program
{
    static void Main()
    {
        int data = int.Parse(Console.ReadLine());
        double[] memoNum = new double[2];

        for (int i = 2; i <= data / 2; i++)
        {
            double diff = data - i;

            if (!IsPrime(i)) continue;
            else if (IsPrime(diff))
            {
                if (memoNum[0] * memoNum[1] < i * diff)
                {
                    memoNum[0] = i;
                    memoNum[1] = diff;
                }
            }
        }

        for (int i = 0; i < memoNum.Length; i++)
        {
            Console.WriteLine(memoNum[i]);
        }
    }

    static bool IsPrime(double n)
    {
        if (n <= 1) return false;
        if (n == 2) return true;
        if (n % 2 == 0) return false;

        for (int i = 3; i * i <= n; i += 2)
        {
            if (n % i == 0) return false;
        }
        return true;
    }
}