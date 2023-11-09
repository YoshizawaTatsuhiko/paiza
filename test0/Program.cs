using System;

class Program
{
    static void Main()
    {
        string str = Console.ReadLine();
        string subStr = Console.ReadLine();
        Console.WriteLine(SubStringCount(str, subStr));
    }

    static int SubStringCount(string str, string subStr)
    {
        if (str.Length < subStr.Length) return 0;

        int count = 0;

        for (int i = 0; i <= str.Length - subStr.Length; i++)
        {
            if (str.Substring(i, subStr.Length) == subStr) count++;
        }
        return count;
    }
}