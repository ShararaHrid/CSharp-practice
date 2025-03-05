using System;

class InsertionSort
{
    public static void Sort(int[] arr)
    {
        int n = arr.Length;
        for (int i = 1; i < n; i++)
        {
            int key = arr[i];
            int j = i - 1;
            while (j >= 0 && arr[j] > key)
            {
                arr[j + 1] = arr[j];
                j--;
            }
            arr[j + 1] = key;
        }
    }

    public static void Main()
    {
        int[] arr = { 9, 5, 1, 4, 3 };
        Sort(arr);
        Console.WriteLine("Insertion Sorted: " + string.Join(", ", arr));
    }
}
