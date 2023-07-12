using System;

public class Program
{
    static void Main()
    {
        int[] data = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        int[,] adjacencyMatrix = new int[data[0], data[0]];

        for (int i = 0; i < data[1]; i++)
        {
            int[] info = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            adjacencyMatrix[info[0] - 1, info[1] - 1] = 1;
            adjacencyMatrix[info[1] - 1, info[0] - 1] = 1;
        }

        for (int i = 0; i < adjacencyMatrix.GetLength(0); i++)
        {
            for (int j = 0; j < adjacencyMatrix.GetLength(1); j++)
            {
                Console.Write(adjacencyMatrix[i, j]);
            }
            Console.Write("\n");
        }
    }
}