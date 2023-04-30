using System;

class Program
{
    static void Main()
    {
        int data = int.Parse(Console.ReadLine());
        
        for (int i = 2; i <= data;)
        {
            if (data % i == 0)
            {
                data /= i;
                Console.WriteLine(i);

                if (data == 0) break;
            }
            else
            {
                i++;
            }
        }
    }
}