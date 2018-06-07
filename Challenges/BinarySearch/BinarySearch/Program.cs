using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            // Array and key data to test working solution
            int[] testArr = new int[] { 1, 3, 5, 7, 9, 10, 11, 12 };
            int testKey = 10;

            // BinarySearch is called on testArr, to find index location of testKey
            // Result is printed to the Console window : -1 logged if testKey out of bounds or not present in testArr
            int result = BinarySearch(testArr, testKey);
            Console.WriteLine(result);

            Console.ReadLine();
        }

        static int BinarySearch(int[] numbers, int key)
        {
            // Instantiate the variables to be used within the BinarySearch algorithm
            int begin = 0, end = numbers.Length, index = end / 2;

            // Checks to ensure that the key is within the bounds of the array
            if (key < numbers[begin] || key > numbers[end - 1])
            {
                return -1;
            }

            // Loops over the array - incrementing or decrementing begin and end values respectively
            // depending on if the key is less than or greater than the current element within the numbers array
            while (begin <= end)
            {
                // Executed if the key has been found within the array
                if (key == numbers[index])
                {
                    return index;
                }
                else if (key < numbers[index])
                {
                    end = index - 1;
                }
                else
                {
                    begin = index + 1;
                }

                index = (begin + end) / 2;
            }

            // Return -1 as the key was not found within the numbers array
            return -1;
        }
    }
}
