using System;

class Program
{
    static void Main()
    {
        Console.Write("enter a number ");
        double number = Convert.ToDouble(Console.ReadLine());

        if (number > 0)
            Console.WriteLine("the number is positive");
        else if (number < 0)
            Console.WriteLine("the number is negative");
        else
            Console.WriteLine("the number is zero");
    }
}

