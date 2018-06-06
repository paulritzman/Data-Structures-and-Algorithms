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
            int[] testArr = new int[] { 1, 3, 5, 7, 9, 10, 11, 12 };
            int testKey = 2;

            int result = BinarySearch(testArr, testKey);
            Console.WriteLine(result); // Should print 2

            Console.ReadLine();
        }

        static int BinarySearch(int[] numbers, int key)
        {
            int begin = 0, end = numbers.Length, index = end / 2;

            while (begin <= end)
            {
                Console.WriteLine(numbers[index]);
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

            return -1;
        }
    }
}
