using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            // Defines an array, instantiated with numbers, to be used as a test of the reverseArray function.
            int[] numArray = new int[] { 89, 2354, 3546, 23, 10, -923, 823, -12 };

            // Stores the reversed array in a variable.
            int[] reversedNums = ReverseArray(numArray);

            // Prints the reversed array to the Console.
            PrintArray(reversedNums);
        }

        static int[] ReverseArray(int[] originalArr)
        {
            // Defines a new array with size equal to the length of the array parameter.
            int[] reversedArr = new int[originalArr.Length];

            // revCount increments by 1 as i decrements by 1 - allowing for revArr to be
            // filled with the elements from the array parameter in reversed order.
            int revCount = 0;
            for (int i = originalArr.Length - 1; i >= 0; i--)
            {
                reversedArr[revCount] = originalArr[i];
                revCount++;
            }

            return reversedArr;
        }

        static void PrintArray(int[] nums)
        {
            // Writes each element to the Console.
            foreach (int num in nums)
            {
                Console.Write($"{num} ");
            }

            // Creates a new line to make the output of printArray more readable in the Console.
            Console.WriteLine();
        }
    }
}