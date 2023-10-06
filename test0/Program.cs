using System;

class Program
{
    static void Main()
    {
        int[] data = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        int x = data[0];
        int d_1 = data[1];
        int d_2 = data[2];
        int k = data[3];
        int[] intArray = new int[1000 + 1];
        intArray[1] = x;
        int[] addValues = new int[] { d_2, d_1 };

        for (int i = 2, n = d_2; i <= 1000; i++, n = addValues[i % 2])
        {
            intArray[i] = intArray[i - 1] + n;
        }
        Console.WriteLine(intArray[k]);
    }
}