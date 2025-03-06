using System;
using System.Linq;

class AnagramChecker
{
    static bool AreAnagrams(string str1, string str2)
    {
        return str1.OrderBy(c => c).SequenceEqual(str2.OrderBy(c => c));
    }

    static void Main()
    {
        Console.Write("Enter first string: ");
        string str1 = Console.ReadLine();
        Console.Write("Enter second string: ");
        string str2 = Console.ReadLine();

        Console.WriteLine(AreAnagrams(str1, str2) ? "Anagrams" : "Not Anagrams");
    }
}
