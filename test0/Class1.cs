using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] data = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        int maxValue = int.MinValue;

        for (int i = 0; i < data[0]; i++)
        {
            Console.ReadLine();

            if (i + 1 == data[1])
            {
                int[] intArray = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

                for (int k = 0; k < intArray.Length; k++)
                {
                    if (maxValue < intArray[k])
                    {
                        maxValue = intArray[k];
                    }
                }
            }
            else
            {
                Console.ReadLine();
                continue;
            }
        }
        Console.WriteLine(maxValue);
    }
}