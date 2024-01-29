using System;

class Program
{
    private static void Main()
    {
        int[] data = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        int h = data[0], w = data[1];
        string[] map = new string[h];

        for (int i = 0; i < h; i++)
        {
            map[i] = Console.ReadLine();
        }
        Console.WriteLine(DonutsCounter(map));
    }

    private static bool IsInRange(string[] map, int r, int c)
    {
        return 0 <= r && r < map.Length && 0 <= c && c < map[r].Length;
    }

    private static int DonutsCounter(string[] map)
    {
        Tuple<int, int>[] dirs = {
            new Tuple<int, int>(-1, -1),
            new Tuple<int, int>(-1, 0),
            new Tuple<int, int>(-1, 1),
            new Tuple<int, int>(0, -1),
            new Tuple<int, int>(0, 1),
            new Tuple<int, int>(1, -1),
            new Tuple<int, int>(1, 0),
            new Tuple<int, int>(1, 1),
        };
        int donutsCount = 0;

        for (int r = 1, count = 0; r < map.Length - 1; r++)
        {
            for (int c = 1; c < map[r].Length - 1; c++, count = 0)
            {
                if (map[r][c] != '.') continue;

                foreach (var dir in dirs)
                {
                    if (!IsInRange(map, r + dir.Item1, c + dir.Item2)) break;
                    if (map[r + dir.Item1][c + dir.Item2] != '#') break;

                    count++;
                }

                if (count == dirs.Length) donutsCount++;
            }
        }
        return donutsCount;
    }
}