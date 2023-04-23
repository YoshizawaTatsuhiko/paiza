using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.ReadLine();
        string[] strArray = Console.ReadLine().Split();
        Stack<int> stack = new Stack<int>();

        for (int i = 0; i < strArray.Length; i++)
        {
            if (int.TryParse(strArray[i], out int result))
            {
                stack.Push(result);
            }
            else
            {
                if (strArray[i] == "+")
                {
                    int a = stack.Pop(), b = stack.Pop();
                    stack.Push(a + b);
                }
                else
                {
                    int a = stack.Pop(), b = stack.Pop();
                    stack.Push(b - a);
                }
            }
        }
        Console.WriteLine(stack.Pop());
    }
}