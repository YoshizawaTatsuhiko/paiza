using System;

class Program
{
    static void Main()
    {
        string str = Console.ReadLine();
        char c = Console.ReadLine()[0];

        for (int i = 0; i < str.Length; i++)
        {
            if (str[i] == c) { Console.WriteLine(i + 1); break; }
        }
    }
}