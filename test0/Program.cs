using System;
using System.Collections.Generic;

class Program
{
    private static void Main()
    {
        int[] intArray = null;

        Console.ReadLine();
        intArray = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

        for (int i = 0, loopCount = int.Parse(Console.ReadLine()); i < loopCount; i++)
        {
            int data = int.Parse(Console.ReadLine());
            int n = Array.BinarySearch(intArray, data);

            Console.WriteLine(n < 0 ? "No" : "Yes");
        }
    }
}