using System;

class Program
{
    static void Main()
    {
        Console.Write("enter the length ");
        double length = Convert.ToDouble(Console.ReadLine());

        Console.Write("enter the width ");
        double width = Convert.ToDouble(Console.ReadLine());

        if (length == width)
            Console.WriteLine("it is a square");
        else
            Console.WriteLine("it is not a square");
    }
}
