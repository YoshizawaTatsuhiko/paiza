using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int[] data = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        int n = data[0];
        int k = data[1];
        List<Tuple<int, int>> edges = new List<Tuple<int, int>>();

        for (int i = 0; i < n - 1; i++)
        {
            int[] edge = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            edges.Add(new Tuple<int, int>(edge[0], edge[1]));
        }
        data = SearchVertex(k, edges);
        Array.Sort(data);

        foreach (var d in data)
        {
            Console.WriteLine(d);
        }
    }

    static int[] SearchVertex(int vertex, List<Tuple<int, int>> edges)
    {
        List<int> adjacencyVertex = new List<int>();

        foreach (var edge in edges)
        {
            if (edge.Item1 == vertex) adjacencyVertex.Add(edge.Item2);
            else if(edge.Item2 == vertex) adjacencyVertex.Add(edge.Item1);
        }
        return adjacencyVertex.ToArray();
    }
}
