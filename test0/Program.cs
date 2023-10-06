using System;

class Program
{
    static void Main()
    {
        int[] intArray = new int[40 + 1]; // 入力される値の最大値 + 1
        intArray[0] = 0;
        intArray[1] = 1;
        int[] indeces = new int[int.Parse(Console.ReadLine())];

        for (int i = 0; i < indeces.Length; i++)
        {
            indeces[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 2; i < intArray.Length; i++)
        {
            intArray[i] = intArray[i - 2] + intArray[i - 1];
        }

        foreach (var index in indeces)
        {
            Console.WriteLine(intArray[index]);
        }
    }
}