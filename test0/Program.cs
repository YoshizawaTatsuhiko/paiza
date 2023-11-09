using System;

class Program
{
    static void Main()
    {
        int[] data = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        int n = data[0], x = data[1];

        for (int i = 0; i < n; i++)
        {
            int[] tmp = Array.ConvertAll(Console.ReadLine().Split(','), int.Parse);

            if (tmp[1] >= x) Console.WriteLine($"{tmp[0]},{tmp[1]}");
        }
    }
}