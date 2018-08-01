using System;

namespace Quick
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] arr = CreateArray();

            PrintArray(arr);
            Console.Write(": unsorted\n\n");

            QuickSort(arr, 0, arr.Length - 1);

            PrintArray(arr);
            Console.Write(": sorted\n\n");

            Console.ReadKey();
        }

        /// <summary>
        /// Creates an integer array and populates the array with initial values.
        /// </summary>
        /// <returns>int[]</returns>
        public static int[] CreateArray()
        {
            return new int[] { 34, 19, 42, -9, 2018, 0, 2005, 77, 2099 };
        }

        /// <summary>
        /// Prints the contents of an integer array to the Console window.
        /// </summary>
        /// <param name="arr">int[]</param>
        public static void PrintArray(int[] arr)
        {
            foreach (int a in arr)
            {
                Console.Write($"{a} ");
            }
        }

        /// <summary>
        /// Uses the middle element in the array as a pivot to iterates over each half of the array.
        /// Swaps values at an index if the element is less than or equal to the pivot.
        /// By iteration completion: all elements less than pivot are on left, all elements larger are on right.
        /// </summary>
        /// <param name="arr">int[]</param>
        /// <param name="left">int</param>
        /// <param name="right">int</param>
        /// <returns>int</returns>
        public static int Partition(int[] arr, int left, int right)
        {
            int pivot = arr[(left + right) / 2];

            while (left <= right)
            {
                while (arr[left] < pivot)
                {
                    left++;
                }
                while (arr[right] > pivot)
                {
                    right--;
                }
                if (left <= right)
                {
                    SwapValues(arr, left, right);

                    left++;
                    right--;
                }
            }

            return left;
        }

        /// <summary>
        /// Helper method used to swap values at specified indexes within the array.
        /// </summary>
        /// <param name="arr">int[]</param>
        /// <param name="left">int</param>
        /// <param name="right">int</param>
        public static void SwapValues(int[] arr, int left, int right)
        {
            int swap = arr[left];
            arr[left] = arr[right];
            arr[right] = swap;
        }

        /// <summary>
        /// Uses a quicksort algorithm to sort an integer array in ascending order.
        /// </summary>
        /// <param name="arr">int[]</param>
        /// <param name="left">int</param>
        /// <param name="right">int</param>
        /// <returns>int[]</returns>
        public static int[] QuickSort(int[] arr, int left, int right)
        {
            int mid = Partition(arr, left, right);

            if (left < mid - 1)
            {
                QuickSort(arr, left, mid - 1);
            }

            if (mid < right)
            {
                QuickSort(arr, mid, right);
            }

            return arr;
        }
    }
}
