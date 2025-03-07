using Sort_Manager;
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
            case 1:
                BubbleSort.Sort(arr);
                break;
            case 2:
                SelectionSort.Sort(arr);
                break;
            case 3:
                InsertionSort.Sort(arr);
                break;
            case 4:
                MergeSort.Sort(arr);
                break;
            case 5:
                QuickSort.Sort(arr);
                break;
            case 6:
                HeapSort.Sort(arr);
                break;
            default:
                Console.WriteLine("Invalid choice!");
                return;
        }

        Console.WriteLine("Sorted Array: " + string.Join(", ", arr));
    }
}
