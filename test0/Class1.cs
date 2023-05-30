using System;

class Program
{
    static void Main()
    {
        int[] data = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        int[] intArray = new int[data[2] + 1];
        intArray[0] = data[1];
        Random random = new Random();

        for (int i = 0; i < data[2]; i++)
        {
            int n = random.Next(1, data[0] + 1);

            while (intArray[i] == n)
            {
                n = random.Next(1, data[0] + 1);
            }
            intArray[i + 1] = n;
        }
        Console.WriteLine(string.Join(" ", intArray));
    }
}