using System;
using System.Collections.Generic;

namespace Merge
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] arr = CreateArray();

            PrintArray(arr);
            Console.Write(": unsorted\n\n");

            MergeSort(arr, 0, arr.Length - 1);

            PrintArray(arr);
            Console.Write(": sorted\n\n");

            Console.ReadKey();
        }

        /// <summary>
        /// Created an integer array and populates the array with initial values
        /// </summary>
        /// <returns>int[]</returns>
        public static int[] CreateArray()
        {
            return new int[] { 34, 19, 42, -9, 2018, 0, 2005, 77, 2099 };
        }

        /// <summary>
        /// Prints the contents of an integer array to the Console window
        /// </summary>
        /// <param name="arr">int[]</param>
        public static void PrintArray(int[] arr)
        {
            foreach (var a in arr)
            {
                Console.Write($"{a} ");
            }
        }

        /// <summary>
        /// Recursive method which sorts an integer array in ascending order
        /// using a "merge sort" algorithm
        /// </summary>
        /// <param name="arr">int[]</param>
        /// <param name="low">int</param>
        /// <param name="high">int</param>
        /// <returns>int[]</returns>
        public static int[] MergeSort(int[] arr, int low, int high)
        {
            if (low < high)
            {
                int mid = (low + high) / 2;

                MergeSort(arr, low, mid);
                MergeSort(arr, mid + 1, high);

                Merge(arr, low, mid, high);
            }

            return arr;
        }

        /// <summary>
        /// Helper method which swaps the indexes of integer array elements
        /// in order to sort the elements in ascending order
        /// </summary>
        /// <param name="arr">int[]</param>
        /// <param name="low">int</param>
        /// <param name="mid">int</param>
        /// <param name="high">int</param>
        /// <returns>int[]</returns>
        public static int[] Merge(int[] arr, int low, int mid, int high)
        {
            int numElements = high - low + 1;

            int[] tempArr = new int[numElements];

            int left = low, right = mid + 1, index = 0;

            while (left <= mid && right <= high)
            {
                tempArr[index++] = (arr[left] <= arr[right]) ? arr[left++] : arr[right++];
            }

            while (left <= mid)
            {
                tempArr[index++] = arr[left++];
            }

            while (right <= high)
            {
                tempArr[index++] = arr[right++];
            }

            for (int i = 0; i < numElements; i++)
            {
                arr[low + i] = tempArr[i];
            }

            return arr;
        }
    }
}
