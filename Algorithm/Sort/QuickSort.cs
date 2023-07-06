namespace Algorithm.Sort
{
    public class QuickSort
    {
        public static void Swap(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }

        public static int Partition(int[] arr, int start, int end)
        {
            int pivot = arr[start];
            int SwapIndex = start;
            for (int i = start + 1; i < end; i++)
            {
                if (arr[i] < pivot)
                {
                    SwapIndex++;
                    Swap(arr, i, SwapIndex);
                }
            }
            Swap(arr, start, SwapIndex);
            return SwapIndex;
        }
        public static int[] QuickSortAlgo(int[] arr, int start, int end)
        {
            if (start < end)
            {
                int pivot = Partition(arr, start, end);
                QuickSortAlgo(arr, start, pivot);
                QuickSortAlgo(arr, pivot + 1, end);
            }
            return arr;
        }
    }
}
