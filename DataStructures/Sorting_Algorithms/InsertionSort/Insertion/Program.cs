using System;

namespace Insertion
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Create an integer array with initial values
            int[] arr = CreateArray();

            // Print contents of the array
            PrintArray(arr);
            Console.WriteLine(": unsorted\n");

            // Use an Insertion Sort algorithm to sort the array
            InsertionSort(arr);

            // Print contents of the array
            PrintArray(arr);
            Console.WriteLine(": sorted\n");

            Console.ReadKey();
        }
        
        /// <summary>
        /// Creates an integer array and populates it with initial values.
        /// </summary>
        /// <returns>int[]</returns>
        public static int[] CreateArray()
        {
            int[] arr = new int[] { 5, 1, 4, 6, 19, 25, 24, 60, 134, 42 };

            return arr;
        }

        /// <summary>
        /// Writes each element of the array to the Console window.
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
        /// Sorts an integer array using an Insertion Sort algorithm.
        /// </summary>
        /// <param name="arr">int[]</param>
        /// <returns>int[]</returns>
        public static int[] InsertionSort(int[] arr)
        {
            int j; // necessary to declare outside of loop, to be used in other code blocks

            for (int i = 1; i < arr.Length; i++)
            {
                int elem = arr[i];
                                
                for (j = i - 1; j >= 0 && arr[j] > elem; j--)
                {
                    arr[j + 1] = arr[j];
                }

                arr[j + 1] = elem;
            }

            return arr;
        }
    }
}
