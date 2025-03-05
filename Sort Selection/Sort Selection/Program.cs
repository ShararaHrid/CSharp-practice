using System;

class SelectionSort
{
    public static void Sort(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n - 1; i++)
        {
            int minIdx = i;
            for (int j = i + 1; j < n; j++)
            {
                if (arr[j] < arr[minIdx])
                    minIdx = j;
            }
            (arr[minIdx], arr[i]) = (arr[i], arr[minIdx]); // Swap
        }
    }

    public static void Main()
    {
        int[] arr = { 29, 10, 14, 37, 13 };
        Sort(arr);
        Console.WriteLine("Selection Sorted: " + string.Join(", ", arr));
    }
}
