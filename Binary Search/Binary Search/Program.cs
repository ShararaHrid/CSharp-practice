using System;

class BinarySearch
{
    static int Search(int[] arr, int key)
    {
        int left = 0, right = arr.Length - 1;
        while (left <= right)
        {
            int mid = left + (right - left) / 2;
            if (arr[mid] == key) return mid;
            else if (arr[mid] < key) left = mid + 1;
            else right = mid - 1;
        }
        return -1;
    }

    static void Main()
    {
        int[] arr = { 1, 3, 5, 7, 9, 11, 15 };
        Console.Write("Enter number to search: ");
        int key = int.Parse(Console.ReadLine());
        int index = Search(arr, key);
        Console.WriteLine(index != -1 ? $"Found at index {index}" : "Not found");
    }
}