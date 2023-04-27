using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.ReadLine();
        string parentheses = Console.ReadLine();
        int count = 0;

        if (parentheses.Length % 2 != 0)
        {
            Console.WriteLine("No");
            return;
        }

        for (int i = 0; i < parentheses.Length - 1; i++)
        {
            if (parentheses[i] == '(')
            {
                count++;
            }
            else if (parentheses[i] == ')')
            {
                count--;
            }

            if (count < 0) break;
        }
        Console.WriteLine(count == 0 ? "Yes" : "No");
    }
}