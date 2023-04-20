using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        Queue<int> queue = new Queue<int>();
        int count = 0;
        int data = int.Parse(Console.ReadLine());

        for (int i = 0; i < data; i++)
        {
            string[] tmp = Console.ReadLine().Split();

            if (tmp[0] == "1")
            {
                queue.Enqueue(int.Parse(tmp[1]));
                count++;
            }
            else
            {
                continue;
            }
        }
        Console.WriteLine(count);

        for (int i = 0; i < data; i++)
        {
            if (queue.Count != 0)
            {
                Console.WriteLine(queue.Dequeue());
            }
        }
    }
}