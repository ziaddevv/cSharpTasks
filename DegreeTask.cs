using System;

class Program
{
    static void Main()
    {
        Console.Write("enter array size ");
        int size = Convert.ToInt32(Console.ReadLine());

        int[] arr = new int[size];

        for (int i = 0; i < size; i++)
        {
            Console.Write($"enter element number {i + 1} ");
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        int max = arr[0], min = arr[0];

        for (int i = 1; i < size; i++)
        {
            if (arr[i] > max)
                max = arr[i];
            if (arr[i] < min)
                min = arr[i];
        }

        Console.WriteLine($"max degree is {max}");
        Console.WriteLine($"min dgree is {min}");
    }
}
