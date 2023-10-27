using System;

class Program
{
    static void Main()
    {
        string[] data = Console.ReadLine().Split();
        int currentY = int.Parse(data[0]);
        int currentX = int.Parse(data[1]);
        string direction = data[2];
        string order = Console.ReadLine();

        switch (direction)
        {
            case "N":
                currentX += order == "R" ? 1 : -1;
                break;
            case "S":
                currentX += order == "R" ? -1 : 1;
                break;
            case "E":
                currentY += order == "R" ? 1 : -1;
                break;
            case "W":
                currentY += order == "R" ? -1 : 1;
                break;
        }
        Console.WriteLine($"{currentY} {currentX}");
    }
}