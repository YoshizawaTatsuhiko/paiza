using System;

class Program
{
    static void Main()
    {
        int data = int.Parse(Console.ReadLine());
        double rootData = Math.Sqrt(data);
        int divisorCount = 0;

        for (int i = 1; i <= rootData; i++)
        {
            if (i == rootData) divisorCount++;
            else if (data % i == 0) divisorCount += 2;
        }
        Console.WriteLine(divisorCount);
    }
}