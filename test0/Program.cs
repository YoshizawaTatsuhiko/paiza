using System;

class Program
{
    static void Main()
    {
        int[] datas = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        int n = datas[0], m = datas[1], k = datas[2], x = datas[3];

        for (int i = 0; i < n; i++)
        {
            int[] data = Array.ConvertAll(Console.ReadLine().Split(','), int.Parse);

            if (data[k - 1] >= x) Console.WriteLine(string.Join(",", data));
        }
    }
}