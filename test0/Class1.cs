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

        for (int i = 0; i <= data[0]; i++)
        {
            Console.ReadLine();
            vertexInfo.Add(i, Array.ConvertAll(Console.ReadLine().Split(), int.Parse));
        }
        SearchRuts(data[1], data[2], list, vertexInfo, result, ref wayCount);
        Console.WriteLine(wayCount);

        for (int i = 0; i < result.Count; i++)
        {
            Console.WriteLine(result[i]);
        }
    }

    static void SearchRuts(int startVertex, int endVertex, List<int> list, Dictionary<int, int[]> vertexInfo, List<string> result, ref int wayCount)
    {
        if (endVertex == startVertex)
        {
            bool hasNotPassedPoint = true;

            for (int i = 0; i < vertexInfo[0].Length; i++)
            {
                if (list.Contains(vertexInfo[0][i])) hasNotPassedPoint = false;
            }

            if (hasNotPassedPoint)
            {
                result.Add(string.Join(" ", list));
                wayCount++;
            }
        }
        else
        {
            for (int i = 0; i < vertexInfo[startVertex].Length; i++)
            {
                int nextVertex = vertexInfo[startVertex][i];

                if (!list.Contains(nextVertex))
                {
                    list.Add(nextVertex);
                    SearchRuts(nextVertex, endVertex, list, vertexInfo, result, ref wayCount);
                    list.RemoveAt(list.Count - 1);
                }
            }
        }
    }
}