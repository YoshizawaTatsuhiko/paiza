using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int[] data = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        int[] intArray = new int[data[2] + 1];
        List<int> vertexNum = new List<int>();
        Random random = new Random();

        for (int i = 1; i <= data[0]; i++)
        {
            if (i == data[1]) intArray[0] = i;
            else vertexNum.Add(i);
        }

        for (int i = 1; i <= data[2]; i++)
        {
            int n = random.Next(vertexNum.Count);
            intArray[i] = vertexNum[n];
            vertexNum.RemoveAt(n);
        }
        Console.WriteLine(string.Join(" ", intArray));
    }
}