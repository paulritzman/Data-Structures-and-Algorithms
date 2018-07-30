using Insertion;
using System;
using Xunit;

namespace UnitTests
{
    public class UnitTest1
    {
        [Fact]
        public void CreateArrayCanCreateAnIntegerArrayWithInitialValues()
        {
            int[] arr = Program.CreateArray();

            int elementCount = arr.Length;

            Assert.Equal(10, elementCount);
        }

        [Theory]
        [InlineData((new int[] { 3, 5, 1, 8, 7 }), (new int[] { 1, 3, 5, 7, 8 }))]
        [InlineData((new int[] { 7, 15, 23, 7, 5}), (new int[] { 5, 7, 7, 15, 23}))]
        [InlineData((new int[] { 155, 0, -345, 23, 42 }), (new int[] { -345, 0, 23, 42, 155}))]
        public void InsertionSortCanUseInsertionAlgorithmToSortArray(int[] arr, int[] expectedArr)
        {
            int[] sortedArr = Program.InsertionSort(arr);

            Assert.Equal(expectedArr, sortedArr);
        }
    }
}
