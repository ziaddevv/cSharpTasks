using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("multiplication table from 1 to 12\n");

        for (int i = 1; i <= 12; i++)
        {
            for (int j = 1; j <= 12; j++)
            {
                Console.Write($"{i * j,4}");
            }
            Console.WriteLine();
        }
    }
}
