using System;

class Program
{
    static void Main()
    {
        int[] datas = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        int h = datas[0];
        int w = datas[1];
        int n = datas[2];
        char[][] mapData = new char[h][];

        for (int i = 0; i < h; i++)
        {
            mapData[i] = Console.ReadLine().ToCharArray();
        }
        
        for (int i = 0; i < n; i++)
        {
            int[] point = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            mapData[point[0]][point[1]] = '#';
        }

        foreach (var data in mapData)
        {
            Console.WriteLine(data);
        }
    }
}