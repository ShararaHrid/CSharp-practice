using System;
using System.Linq;

class SecondLargest
{
    static int FindSecondLargest(int[] arr)
    {
        if (arr.Length < 2)
            throw new ArgumentException("Array must have at least two elements");

        int first = int.MinValue, second = int.MinValue;

        foreach (var num in arr)
        {
            if (num > first)
            {
                second = first;
                first = num;
            }
            else if (num > second && num != first)
            {
                second = num;
            }
        }
        return second;
    }

    static void Main()
    {
        int[] arr = { 12, 35, 1, 10, 34, 1 };
        Console.WriteLine("Second largest: " + FindSecondLargest(arr));
    }
}