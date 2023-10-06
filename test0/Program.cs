using System;

class Program
{
    static void Main()
    {
        int[] data = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        int x = data[0];
        int d_1 = data[1];
        int d_2 = data[2];
        int[] indeces = new int[int.Parse(Console.ReadLine())];
        int[] intArray = new int[1000 + 1];
        intArray[1] = x;
        int[] addValues = new int[] { d_2, d_1 };

        for (int i = 0; i < indeces.Length; i++)
        {
            indeces[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 2, n = d_2; i <= 1000; i++, n = addValues[i % 2])
        {
            intArray[i] = intArray[i - 1] + n;
        }

        for (int i = 0; i < indeces.Length; i++)
        {
            Console.WriteLine(intArray[indeces[i]]);
        }
    }
}