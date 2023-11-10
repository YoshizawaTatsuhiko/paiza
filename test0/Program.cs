using System;

class Program
{
    static void Main()
    {
        int[] datas = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        int h = datas[0], w = datas[1], y = datas[2], x = datas[3];
        int[,] map = new int[w, h];
        int walkCount = 3;
        BFS(map, y, x, walkCount);
    }

    static Tuple<int, int>[] _dirs = new Tuple<int, int>[]
    {
        new Tuple<int, int>(-1, 0),
        new Tuple<int, int>(0, 1),
        new Tuple<int, int>(1, 0),
        new Tuple<int, int>(0, -1),
    };

    static void BFS(int[,] map, int startY, int startX, int walkCount)
    {
        if (walkCount == 0)
        {
            Console.WriteLine($"{startY} {startX}");
            return;
        }

        foreach (var direction in _dirs)
        {
            int nextY = startY + direction.Item1;
            int nextX = startX + direction.Item2;

            if (0 <= nextY && nextY < map.GetLength(1) && 0 <= nextX && nextX < map.GetLength(0))
            {
                BFS(map, nextY, nextX, walkCount - 1);
            }
        }
    }
}