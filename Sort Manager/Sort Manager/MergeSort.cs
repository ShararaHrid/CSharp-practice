using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort_Manager
{
    class MergeSort
    {
        public static void Sort(int[] arr)
        {
            MergeSortRecursive(arr, 0, arr.Length - 1);
        }

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
            {
                arr[k++] = (leftArray[i] <= rightArray[j]) ? leftArray[i++] : rightArray[j++];
            }
            while (i < leftArray.Length) arr[k++] = leftArray[i++];
            while (j < rightArray.Length) arr[k++] = rightArray[j++];
        }
    }
}
