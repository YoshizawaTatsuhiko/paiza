using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int[] data = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

        for (int i = 1; i <= data[0]; i++)
        {
            Console.ReadLine();

            if (i == data[1])
            {
                int[] vertices = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                Array.Sort(vertices);

                if (vertices.Length > 0) Console.WriteLine(string.Join(" ", vertices));
                else Console.WriteLine(-1);
            }
            else
            {
                Console.ReadLine();
            }
        }
    }
}