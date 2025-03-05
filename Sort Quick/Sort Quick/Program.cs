using System;

class QuickSort
{
    public static void Sort(int[] arr, int low, int high)
    {
        if (low < high)
        {
            int pi = Partition(arr, low, high);
            Sort(arr, low, pi - 1);
            Sort(arr, pi + 1, high);
        }
    }

    private static int Partition(int[] arr, int low, int high)
    {
        int pivot = arr[high];
        int i = low - 1;
        for (int j = low; j < high; j++)
        {
            if (arr[j] < pivot)
            {
                i++;
                (arr[i], arr[j]) = (arr[j], arr[i]); // Swap
            }
        }
        (arr[i + 1], arr[high]) = (arr[high], arr[i + 1]);
        return i + 1;
    }

    public static void Main()
    {
        int[] arr = { 10, 7, 8, 9, 1, 5 };
        Sort(arr, 0, arr.Length - 1);
        Console.WriteLine("Quick Sorted: " + string.Join(", ", arr));
    }
}
