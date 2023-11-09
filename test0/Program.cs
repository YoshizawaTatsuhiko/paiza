using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<char, int> alphabetDic = new Dictionary<char, int>();
        string str = Console.ReadLine();

        for (char alph = 'a'; alph <= 'z'; alph++)
        {
            alphabetDic[alph] = 0;
        }

        for (int i = 0; i < str.Length; i++)
        {
            alphabetDic[str[i]]++;
        }

        foreach (var item in alphabetDic)
        {
            Console.WriteLine(item.Value);
        }
    }
}