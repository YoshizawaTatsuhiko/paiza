using System;

class Program
{
    static void Main()
    {
        int[] data = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        int[] intArray = new int[data[2]];
        intArray[0] = data[0];

        for (int i = 1; i < data[2]; i++)
        {
            intArray[i] = intArray[i - 1] + data[1];
        }
        Console.WriteLine(intArray[data[2] - 1]);
    }
}
