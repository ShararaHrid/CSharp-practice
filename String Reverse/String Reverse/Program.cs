using System;

class ReverseString
{
    static string Reverse(string str) => new string(str.ToCharArray().Reverse().ToArray());

    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();
        Console.WriteLine("Reversed: " + Reverse(input));
    }
}
