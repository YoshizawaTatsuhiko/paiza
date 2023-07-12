using System;
using System.Collections.Generic;

public class Program
{
    static void Main()
    {
        int[] data = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        int[,] adjacencyMatrix = new int[data[0], data[0]];
        Dictionary<int, List<int>> adjacencyList = new Dictionary<int, List<int>>();

        for (int i = 0; i < data[0]; i++)
        {
            adjacencyList.Add(i, new List<int>());
        }

        for (int i = 0; i < data[1]; i++)
        {
            int[] info = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            adjacencyMatrix[info[0] - 1, info[1] - 1] = 1;
            adjacencyList[info[0] - 1].Add(info[1] - 1);
        }

        for (int i = 0; i < data[0]; i++)
        {
            for (int j = 0; j < data[0]; j++)
            {
                Console.Write(adjacencyMatrix[i, j]);
            }
            Console.Write('\n');
        }

        for (int i = 0; i < data[0]; i++)
        {
            if (adjacencyList[i].Count > 0)
            {
                adjacencyList[i].Sort();
            }

            foreach (var n in adjacencyList[i])
            {
                Console.Write(n);
            }
            Console.Write('\n');
        }
    }
}