using System;

public class Program
{
    static void Main()
    {
        Console.ReadLine();
        int[] temperatureArray = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        int min = int.MaxValue;
        int max = int.MinValue;

        for (int i = 0; i < temperatureArray.Length; i++)
        {
            if (min > temperatureArray[i]) min = temperatureArray[i];
            if (max < temperatureArray[i]) max = temperatureArray[i];
        }
        Console.WriteLine(max - min);
    }
}