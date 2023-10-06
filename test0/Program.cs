using System;

class Program
{
    static void Main()
    {
        int[] data = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        int n = int.Parse(Console.ReadLine());
        int[] intArray = new int[1000 + 1];
        intArray[1] = data[0];
        int[] indeces = new int[n];

        for (int i = 0; i < n; i++)
        {
            indeces[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 2; i <= 1000; i++)
        {
            intArray[i] = intArray[i - 1] + data[1];
        }

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(intArray[indeces[i]]);
        }
    }
}