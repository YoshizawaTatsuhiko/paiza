using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int[] datas = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        int h = datas[0];
        int w = datas[1];
        char[][] mapData = new char[h][];
        List<Tuple<int, int>> coodinate = new List<Tuple<int, int>>();
        bool isMatching = false;

        for (int i = 0; i < h; i++)
        {
            mapData[i] = Console.ReadLine().ToCharArray();
        }
        
        for (int r = 0; r < h; r++)
            for (int c = 0; c < w; c++)
            {
                if (c == 0)
                    isMatching = mapData[r][c + 1] == '#';
                else if (c == w - 1)
                    isMatching = mapData[r][c - 1] == '#';
                else 
                    isMatching = mapData[r][c + 1] == '#' && mapData[r][c - 1] == '#';

                if (isMatching)
                {
                    coodinate.Add(new Tuple<int, int>(r, c));
                    isMatching = false;
                }
            }

        foreach (var cood in coodinate)
        {
            Console.WriteLine($"{cood.Item1} {cood.Item2}");
        }
    }
}