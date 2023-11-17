using System;
using System.Collections.Generic;
using System.Text;

class Program
{
    private static HashSet<Coord> _myArea = new HashSet<Coord>();
    private static Tuple<int, int>[] _searchDir =
    {
        new Tuple<int, int>(-1, +0), // UP
        new Tuple<int, int>(+1, +0), // DOWN
        new Tuple<int, int>(+0, -1), // LEFT
        new Tuple<int, int>(+0, +1), // RIGHT
    };

    static void Main()
    {
        int[] data = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        int h = data[0], w = data[1];
        StringBuilder[] map = new StringBuilder[h];
        Tuple<int, int> myPos = null;

        for (int r = 0; r < map.Length; r++)
        {
            string str = Console.ReadLine();
            map[r] = new StringBuilder(str);

            for (int c = 0; c < str.Length && myPos == null; c++)
            {
                if (str[c] == '*') myPos = new Tuple<int, int>(r, c);
            }
        }
        Invade(map, myPos.Item1, myPos.Item2);

        foreach (var line in map) Console.WriteLine(line);
    }

    static bool IsIndexInRange(StringBuilder[] map, int r, int c)
    {
        return 0 <= r && r < map.Length && 0 <= c && c < map[r].Length;
    }

    static void Invade(StringBuilder[] map, int startRow, int startCol)
    {
        if (!IsIndexInRange(map, startRow, startCol)) return;
        if (_myArea.Contains(new Coord(startRow, startCol))) return;
        if (map[startRow][startCol] == '#') return;

        map[startRow][startCol] = '*';
        _myArea.Add(new Coord(startRow, startCol));

        foreach (var dir in _searchDir)
        {
            int nextRow = startRow + dir.Item1;
            int nextCol = startCol + dir.Item2;
            Invade(map, nextRow, nextCol);
        }
    }
}

struct Coord
{
    public int Y;
    public int X;

    public Coord(int y, int x)
    {
        Y = y;
        X = x;
    }
}