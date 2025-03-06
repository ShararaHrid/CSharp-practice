using System;

class BubbleSort
{
    public static void Sort(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                    (arr[j], arr[j + 1]) = (arr[j + 1], arr[j]); // Swap
            }
        }
    }
}

class SelectionSort
{
    public static void Sort(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n - 1; i++)
        {
            int minIndex = i;
            for (int j = i + 1; j < n; j++)
                if (arr[j] < arr[minIndex]) minIndex = j;
            (arr[minIndex], arr[i]) = (arr[i], arr[minIndex]); // Swap
        }
    }
}

class InsertionSort
{
    public static void Sort(int[] arr)
    {
        int n = arr.Length;
        for (int i = 1; i < n; i++)
        {
            int key = arr[i], j = i - 1;
            while (j >= 0 && arr[j] > key)
            {
                arr[j + 1] = arr[j];
                j--;
            }
            arr[j + 1] = key;
        }
    }
}

class MergeSort
{
    public static void Sort(int[] arr) => MergeSortRecursive(arr, 0, arr.Length - 1);

    private static void MergeSortRecursive(int[] arr, int left, int right)
    {
        if (left >= right) return;
        int mid = left + (right - left) / 2;
        MergeSortRecursive(arr, left, mid);
        MergeSortRecursive(arr, mid + 1, right);
        Merge(arr, left, mid, right);
    }

    private static void Merge(int[] arr, int left, int mid, int right)
    {
        int[] leftArray = arr[left..(mid + 1)];
        int[] rightArray = arr[(mid + 1)..(right + 1)];
        int i = 0, j = 0, k = left;
        while (i < leftArray.Length && j < rightArray.Length)
            arr[k++] = leftArray[i] <= rightArray[j] ? leftArray[i++] : rightArray[j++];
        while (i < leftArray.Length) arr[k++] = leftArray[i++];
        while (j < rightArray.Length) arr[k++] = rightArray[j++];
    }
}

class QuickSort
{
    public static void Sort(int[] arr) => QuickSortRecursive(arr, 0, arr.Length - 1);

    private static void QuickSortRecursive(int[] arr, int low, int high)
    {
        if (low < high)
        {
            int pivotIndex = Partition(arr, low, high);
            QuickSortRecursive(arr, low, pivotIndex - 1);
            QuickSortRecursive(arr, pivotIndex + 1, high);
        }
    }

    private static int Partition(int[] arr, int low, int high)
    {
        int pivot = arr[high], i = low - 1;
        for (int j = low; j < high; j++)
        {
            if (arr[j] < pivot)
            {
                i++;
                (arr[i], arr[j]) = (arr[j], arr[i]);
            }
        }
        (arr[i + 1], arr[high]) = (arr[high], arr[i + 1]);
        return i + 1;
    }
}

class HeapSort
{
    public static void Sort(int[] arr)
    {
        int n = arr.Length;
        for (int i = n / 2 - 1; i >= 0; i--) Heapify(arr, n, i);
        for (int i = n - 1; i > 0; i--)
        {
            (arr[0], arr[i]) = (arr[i], arr[0]); // Swap
            Heapify(arr, i, 0);
        }
    }

    private static void Heapify(int[] arr, int n, int i)
    {
        int largest = i, left = 2 * i + 1, right = 2 * i + 2;
        if (left < n && arr[left] > arr[largest]) largest = left;
        if (right < n && arr[right] > arr[largest]) largest = right;
        if (largest != i)
        {
            (arr[i], arr[largest]) = (arr[largest], arr[i]);
            Heapify(arr, n, largest);
        }
    }
}

class SortManager
{
    public static void Main()
    {
        Console.WriteLine("Choose Sorting Algorithm: ");
        Console.WriteLine("1. Bubble Sort\n2. Selection Sort\n3. Insertion Sort\n4. Merge Sort\n5. Quick Sort\n6. Heap Sort");
        Console.Write("Enter choice (1-6): ");
        int choice = int.Parse(Console.ReadLine());

        int[] arr = { 64, 25, 12, 22, 11 };
        Console.WriteLine("\nOriginal Array: " + string.Join(", ", arr));

        switch (choice)
        {
            case 1: BubbleSort.Sort(arr); break;
            case 2: SelectionSort.Sort(arr); break;
            case 3: InsertionSort.Sort(arr); break;
            case 4: MergeSort.Sort(arr); break;
            case 5: QuickSort.Sort(arr); break;
            case 6: HeapSort.Sort(arr); break;
            default: Console.WriteLine("Invalid choice!"); return;
        }

        Console.WriteLine("Sorted Array: " + string.Join(", ", arr));
    }
}
