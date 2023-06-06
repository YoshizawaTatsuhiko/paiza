using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int[] data = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        Dictionary<int, int[]> vertexInfo = new Dictionary<int, int[]>();
        List<string> result = new List<string>();
        List<int> list = new List<int>();
        list.Add(data[1]);
        int wayCount = 0;

        for (int i = 1; i <= data[0]; i++)
        {
            Console.ReadLine();
            vertexInfo.Add(i, Array.ConvertAll(Console.ReadLine().Split(), int.Parse));
        }
        SearchRuts(data[1], list, data[2], vertexInfo, result, ref wayCount);
        Console.WriteLine(wayCount);

        for (int i = 0; i < result.Count; i++)
        {
            Console.WriteLine(result[i]);
        }
    }

    static void SearchRuts(int vertex, List<int> list,
        int walkCount, Dictionary<int, int[]> vertexInfo, List<string> result, ref int wayCount)
    {
        if (walkCount <= 0)
        {
            result.Add(string.Join(" ", list));
            wayCount++;
        }
        else
        {
            for (int i = 0; i < vertexInfo[vertex].Length; i++)
            {
                int nextVertex = vertexInfo[vertex][i];
                list.Add(nextVertex);
                SearchRuts(nextVertex, list, walkCount - 1, vertexInfo, result, ref wayCount);
                list.RemoveAt(list.Count - 1);
            }
        }
    }
}