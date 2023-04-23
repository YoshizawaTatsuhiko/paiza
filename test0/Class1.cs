using System;
using System.Collections.Generic;
using System.IO.MemoryMappedFiles;

class Program
{
    static void Main()
    {
        Console.ReadLine();
        string parentheses = Console.ReadLine();
        int nextSearchIndex = 0;
        int count = 0;

        for (int i = 0; i < parentheses.Length - 1; i++)
        {
            if (parentheses[i] == '(')
            {
                if (i == 0) nextSearchIndex = i + 1;

                for (int j = nextSearchIndex; j < parentheses.Length; j++)
                {
                    if (parentheses[j] == ')')
                    {
                        nextSearchIndex = j + 1;
                        count++;
                        break;
                    }
                }
            }
        }
        bool isCollect = count == parentheses.Length / 2 && parentheses.Length % 2 == 0;
        Console.WriteLine(isCollect ? "Yes" : "No");
    }
}