using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int data = int.Parse(Console.ReadLine().Split()[1]);
        int[] intArray = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        int maxValue = int.MinValue;
        int rememberIndex = 0;
        int sum = 0;

        for (int i = 0; i < intArray.Length - (data - 1); i++)
        {
            if (i == 0)
            {
                for (int j = i; j < data; j++)
                {
                    sum += intArray[j];
                }
            }
            else
            {
                sum = sum - intArray[i - 1] + intArray[i + data - 1];
            }

            if (maxValue < sum)
            {
                maxValue = sum;
                rememberIndex = i;
            }
        }
        Console.WriteLine($"{maxValue} {intArray[rememberIndex]}");
    }
}