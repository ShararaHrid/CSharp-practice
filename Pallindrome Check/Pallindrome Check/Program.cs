using System;

class PalindromeChecker
{
    static bool IsPalindrome(string str)
    {
        str = str.ToLower();
        return str == new string(str.Reverse().ToArray());
    }

    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();
        Console.WriteLine(IsPalindrome(input) ? "Palindrome" : "Not a Palindrome");
    }
}
