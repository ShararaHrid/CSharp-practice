using System;

class MergeSort
{
    public static void Sort(int[] arr, int left, int right)
    {
        if (left < right)
        {
            int mid = (left + right) / 2;
            Sort(arr, left, mid);
            Sort(arr, mid + 1, right);
            Merge(arr, left, mid, right);
        }
    }

    private static void Merge(int[] arr, int left, int mid, int right)
    {
        int n1 = mid - left + 1;
        int n2 = right - mid;
        int[] leftArr = new int[n1];
        int[] rightArr = new int[n2];

        Array.Copy(arr, left, leftArr, 0, n1);
        Array.Copy(arr, mid + 1, rightArr, 0, n2);

        int i = 0, j = 0, k = left;
        while (i < n1 && j < n2)
        {
            arr[k++] = (leftArr[i] <= rightArr[j]) ? leftArr[i++] : rightArr[j++];
        }

        while (i < n1) arr[k++] = leftArr[i++];
        while (j < n2) arr[k++] = rightArr[j++];
    }

    public static void Main()
    {
        int[] arr = { 38, 27, 43, 3, 9, 82, 10 };
        Sort(arr, 0, arr.Length - 1);
        Console.WriteLine("Merge Sorted: " + string.Join(", ", arr));
    }
}
