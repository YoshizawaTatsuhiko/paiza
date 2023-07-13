using System;

public class Program
{
    static void Main()
    {
        int[] boardSize = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        int height = boardSize[0];
        int width = boardSize[1];
        Console.WriteLine(height * width / 2);
    }
}