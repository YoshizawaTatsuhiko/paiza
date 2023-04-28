using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int data = int.Parse(Console.ReadLine());
        Dictionary<int, string> dic = new Dictionary<int, string>();

        for (int i = 0; i < data; i++)
        {
            int n = int.Parse(Console.ReadLine());

            if (dic.ContainsKey(n))
            {
                Console.WriteLine(dic[n]);
                continue;
            }
            
            if (IsPrime(n))
            {
                dic.Add(n, "pass");
            }
            else
            {
                dic.Add(n, "failure");
            }
            Console.WriteLine(dic[n]);
        }
    }

    static bool IsPrime(int n)
    {
        if (n <= 1) return false;
        if (n == 2) return true;
        if (n % 2 == 0) return false;

        for (int i = 3; i <= Math.Sqrt(n); i += 2)
        {
            if(n % i == 0) return false;
        }
        return true;
    }
}