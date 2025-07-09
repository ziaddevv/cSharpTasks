using System;

class Program
{
    static void Main()
    {
        Console.Write("enter an integer ");
        int number = Convert.ToInt32(Console.ReadLine());

        if (number % 2 == 0)
            Console.WriteLine("the number is even");
        else
            Console.WriteLine("the number is odd");
    }
}
