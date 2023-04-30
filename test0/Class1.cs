using System;

class Program
{
    static void Main()
    {
        int data = int.Parse(Console.ReadLine());
        //int randomNumber = new Random().Next(2, data);
        int randomNumber = 2;
        int fermat = 1;

        for (int i = 0; i < data - 1; i++)
        {
            fermat *= randomNumber;
            fermat = fermat % data;
        }
        bool isPrime = data % randomNumber != 0 && fermat == 1;
        Console.WriteLine(isPrime ? "YES" : "NO");
    }
}