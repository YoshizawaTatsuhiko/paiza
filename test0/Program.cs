using System;

class Program
{
    static void Main()
    {
        int[] data = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        int currentY = data[0];
        int currentX = data[1];
        int orderCount = data[2];

        for (int i = 0; i < orderCount; i++)
        {
            switch (Console.ReadLine())
            {
                case "N":
                    currentY--;
                    break;
                case "S":
                    currentY++;
                    break;
                case "E":
                    currentX++;
                    break;
                case "W":
                    currentX--;
                    break;
            }
            Console.WriteLine($"{currentY} {currentX}");
        }
    }
}