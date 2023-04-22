using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int data = int.Parse(Console.ReadLine());
        Queue<string> queueFirst = new Queue<string>();
        Queue<string> queueSecond = new Queue<string>();

        for (int i = 0; i < data; i++)
        {
            string[] order = Console.ReadLine().Split();

            if (order[0] == "1")
            {
                switch (order[1])
                {
                    case "1":
                        queueFirst.Enqueue(order[2]);
                        break;
                    case "2":
                        queueSecond.Enqueue(order[2]);
                        break;
                }
            }
            else if (order[0] == "2")
            {
                switch (order[1])
                {
                    case "1":
                        Console.WriteLine(queueFirst.Peek());
                        queueFirst.Dequeue();
                        break;
                    case "2":
                        Console.WriteLine(queueSecond.Peek());
                        queueSecond.Dequeue();
                        break;
                }
            }
            else
            {
                Console.WriteLine($"{queueFirst.Count} {queueSecond.Count}");
            }
        }
    }
}