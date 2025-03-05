using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter name");
        Console.WriteLine("Hello " + Console.ReadLine()); //string concatenation

        Console.WriteLine("name please");
        Console.WriteLine("hi {0}", Console.ReadLine()); //placeholder
    }
}