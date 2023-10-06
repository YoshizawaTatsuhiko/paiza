using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] intArray = new int[40 + 1]; // 入力される値の最大値 + 1
        intArray[0] = 0;
        intArray[1] = 1;

        for (int i = 2; i < intArray.Length; i++)
        {
            intArray[i] = intArray[i - 2] + intArray[i - 1];
        }
        Console.WriteLine(intArray[n]);
    }
}