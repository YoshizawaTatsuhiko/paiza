using System;
using System.Text;

class Program
{
    static void Main()
    {
        int[] data = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        int h = data[0], w = data[1];
        StringBuilder[] map = new StringBuilder[h];
        Tuple<int, int> myPos = null;
        Tuple<int, int>[] searchDir =
        {
            new Tuple<int, int>(-1, +0), // UP
            new Tuple<int, int>(+1, +0), // DOWN
            new Tuple<int, int>(+0, -1), // LEFT
            new Tuple<int, int>(+0, +1), // RIGHT
        };

        for (int r = 0; r < map.Length; r++)
        {
            string str = Console.ReadLine();
            map[r] = new StringBuilder(str);

            for (int c = 0; c < str.Length && myPos == null; c++)
            {
                if (str[c] == '*') myPos = new Tuple<int, int>(r, c);
            }
        }

        foreach (var dir in searchDir)
        {
            int newRow = myPos.Item1 + dir.Item1;
            int newCol = myPos.Item2 + dir.Item2;

            if (IsIndexInRange(map, newRow, newCol) && map[newRow][newCol] != '#')
            {
                map[newRow][newCol] = '*';
            }
        }

        foreach (var line in map) Console.WriteLine(line);
    }

    static bool IsIndexInRange(StringBuilder[] map, int r, int c)
    {
        return 0 <= r && r < map.Length && 0 <= c && c < map[r].Length;
    }
}