using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    static void Main()
    {
        int[] nm = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        List<Tuple<int, int>> edges = new List<Tuple<int, int>>();
        HashSet<int> visited = new HashSet<int>();
        bool[] stampCard = new bool[nm[0]];

        for (int i = 0; i < nm[1]; i++)
        {
            int[] datas = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            edges.Add(new Tuple<int, int>(datas[0], datas[1]));
        }
        BFS(1, edges, visited, stampCard);

        Console.WriteLine(stampCard.All(a => a == true) ? "YES" : "NO");
    }

    static void BFS(int current, List<Tuple<int, int>> edges, HashSet<int> visited, bool[] stampCard)
    {
        visited.Add(current);
        stampCard[current - 1] = true;

        foreach (var edge in edges)
        {
            if (current == edge.Item1 && !visited.Contains(edge.Item2))
            {
                BFS(edge.Item2, edges, visited, stampCard);
            }
            else if(current == edge.Item2 && !visited.Contains(edge.Item1))
            {
                BFS(edge.Item1, edges, visited, stampCard);
            }
        }
    }
}