using System;

class Program
{
    static void Main()
    {
        Console.ReadLine();
        int[] getOffPassengers = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        int[] getOnPassengers = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        int maxPassenger = 0;

        for (int i = 0, count = 0; i < getOnPassengers.Length; i++)
        {
            count += -getOffPassengers[i] + getOnPassengers[i];

            if (count > maxPassenger) maxPassenger = count;
        }
        Console.WriteLine(maxPassenger);
    }
}