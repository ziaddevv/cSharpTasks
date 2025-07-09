using System;

class Program
{
    static void Main()
    {
        int id;
        do
        {
            Console.Write("enter id ");
            id = Convert.ToInt32(Console.ReadLine());
        } while (id <= 0);

        string name;
        bool hasDigit;
        do
        {
            Console.Write("enter name ");
            name = Console.ReadLine();
            hasDigit = false;
            foreach (char c in name)
            {
                if (c >= '0' && c <= '9')
                {
                    hasDigit = true;
                    break;
                }
            }
        } while (hasDigit);

        int age;
        do
        {
            Console.Write("enter age ");
            age = Convert.ToInt32(Console.ReadLine());
        } while (age <= 0);

        Console.Write("enter salary ");
        float salary = float.Parse(Console.ReadLine());

        Console.WriteLine($"id: {id}, name: {name}, age: {age}, salary: {salary}");
    }
}
