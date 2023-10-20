using System;

class Program
{
    static void Main()
    {
        int[] datas = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        int h = datas[0];
        int w = datas[1];
        string[] mapData = new string[h + 2];
        string dummyData = null;

        for (int i = 0; i < w + 2; i++) dummyData += '#';

        for (int i = 0; i < mapData.Length; i++)
        {
            if(i == 0 || i == mapData.Length - 1) { mapData[i] = dummyData; continue; }

            mapData[i] = $"#{Console.ReadLine()}#";
        }
        
        for (int r = 1; r <= h; r++)
            for (int c = 1; c <= w; c++)
            {
                if (IsSurround(mapData, r, c)) Console.WriteLine($"{r - 1} {c - 1}");
            }
    }

    static bool IsSurround(string[] mapData, int r, int c)
    {
        int n = 0;

        if (mapData[r + 1][c] == '#') n++;
        if (mapData[r - 1][c] == '#') n++;
        if (mapData[r][c + 1] == '#') n++;
        if (mapData[r][c - 1] == '#') n++;

        return n == 4;
    }
}