using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        float ops = 0f;
        int batterNum = 1;

        for (int i = 1; i <= n; i++)
        {
            float[] tmp = Array.ConvertAll(Console.ReadLine().Split(), float.Parse);
            float tmpOps = tmp[0] + tmp[1];

            if (tmpOps > ops)
            {
                ops = tmpOps;
                batterNum = i;
            }
        }
        Console.WriteLine(batterNum);
    }
}