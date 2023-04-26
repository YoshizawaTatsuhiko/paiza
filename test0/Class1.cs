using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int data = int.Parse(Console.ReadLine().Split()[1]);
        int[] intArray = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        Queue<int> queue = new Queue<int>();
        int index = 0;
        int passengerCount = 0;

        for (int i = 1; i <= intArray[intArray.Length - 1]; i++)
        {
            bool judge = intArray[index] == i;

            if (judge)
            {
                queue.Enqueue(1);
                index++;
                passengerCount++;
            }
            else
            {
                queue.Enqueue(0);
            }

            if (queue.Count > data)
            {
                passengerCount -= queue.Dequeue();
            }

            if (judge) Console.WriteLine(passengerCount);
        }
    }
}