using System;

class Program
{
    static void Main()
    {
        int[] datas = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        int h = datas[0];
        int w = datas[1];
        int n = datas[2];
        string[] mapData = new string[w];

        for (int i = 0; i < h; i++)
        {
            mapData[i] = Console.ReadLine();
        }

        for (int i = 0; i < n; i++)
        {
            int[] point = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            Console.WriteLine(mapData[point[0]][point[1]]);
        }
    }
}