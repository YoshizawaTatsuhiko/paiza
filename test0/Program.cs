using System;

class Program
{
    static void Main()
    {
        int[] data = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        int h = data[0];
        int w = data[1];
        string str = "";

        for (int r = 0; r < h; r++)
        {
            str = Console.ReadLine();

            for(int c = 0; c < w; c++)
            {
                if (str[c] == '#') { Console.WriteLine($"{r} {c}"); break; }
            }
        }
    }
}