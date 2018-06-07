using System;

namespace AdjacentProduct
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiates a 2-dimensional array
            int[,] arr2D = new int[,] { { 1, 2, 1 }, { 2, 4, 2 }, { 3, 6, 8 }, { 7, 8, 1 } };
            
            try
            {
                // Prints the returned value from the LargestProduct method to the Console window
                int largest = LargestProduct(arr2D);
                Console.WriteLine($"The largest product of adjacent elements is: {largest}");
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Please provide at least one integer to the array.");
            }

            Console.ReadLine();
        }

        /// <summary>
        /// Method which calculates the largest product of two adjacent elements from within a 2-dimensional array.
        /// </summary>
        /// <param name="array">2-Dimensional Array</param>
        /// <returns>Integer: Largest product of two adjacent elements</returns>
        static int LargestProduct(int[,] array)
        {
            // Initially sets the value of "largest" to the first element in the 2D array.
            int largest = array[0, 0];
            int lengthFirstDim = array.GetLength(0);
            int lengthSecondDim = array.GetLength(1);

            // Iterate over the first and second dimensions of the array to test every pairing
            for (int i = 0; i < lengthFirstDim; i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    // Checks the product of the current element and the element to the right, if one exists
                    if ((j != lengthSecondDim - 1) && ((array[i, j] * array[i, j + 1]) > largest))
                    {
                        largest = array[i, j] * array[i, j + 1];
                    }

                    // Checks the product of the current element and the element below it, if one exists
                    if ((i != lengthFirstDim - 1) && ((array[i, j] * array[i + 1, j]) > largest))
                    {
                        largest = array[i, j] * array[i + 1, j];
                    }

                    // Checks the product of the current element and the element below it and to the left, if one exists
                    if ((i != 0) && (j != lengthSecondDim - 1) && ((array[i, j] * array[i - 1, j + 1]) > largest))
                    {
                        largest = array[i, j] * array[i - 1, j + 1];
                    }

                    // Checks the product of the current element and the element below it and to the right, if one exists
                    if ((i != lengthFirstDim - 1) && (j != lengthSecondDim - 1) && ((array[i, j] * array[i + 1, j + 1]) > largest))
                    {
                        largest = array[i, j] * array[i + 1, j + 1];
                    }
                }
            }

            return largest;
        }
    }
}