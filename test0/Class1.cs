using System;
using System.Collections.Generic;

public class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        List<Tuple<int, int>> edges = new List<Tuple<int, int>>();
        HashSet<int> visited = new HashSet<int>();

        for (int i = 0; i < n - 1; i++)
        {
            int[] datas = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            edges.Add(new Tuple<int, int>(datas[0], datas[1]));
        }
        BFS(1, edges, visited);

        foreach (var trail in visited)
        {
            Console.WriteLine(trail);
        }
    }

    static void BFS(int current, List<Tuple<int, int>> edges, HashSet<int> visited)
    {
        visited.Add(current);

        foreach (var edge in edges)
        {
            if (current == edge.Item1 && !visited.Contains(edge.Item2))
            {
                BFS(edge.Item2, edges, visited);
            }
            else if(current == edge.Item2 && !visited.Contains(edge.Item1))
            {
                BFS(edge.Item1, edges, visited);
            }
        }
    }
}