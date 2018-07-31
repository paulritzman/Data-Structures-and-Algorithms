using Merge;
using System;
using Xunit;

namespace UnitTests
{
    public class UnitTest1
    {
        [Fact]
        public void CreateArrayCanCreateANewIntegerArrayAndPopulateItWithInitialValues()
        {
            int[] arr = Program.CreateArray();
            
            Assert.NotEmpty(arr);
        }

        [Theory]
        [InlineData((new int[] { 5, 1 }), (new int[] { 1, 5 }))]
        [InlineData((new int[] { 5, -1 }), (new int[] { -1, 5 }))]
        [InlineData((new int[] { -1, -10 }), (new int[] { -10, -1 }))]
        public void MergeCanFlipIndexesInArrayBySortingInAscendingOrder(int[] arrToSort, int[] arrExpected)
        {
            int low = 0, high = arrToSort.Length - 1, mid = (low + high) / 2;

            int[] sortedArr = Program.Merge(arrToSort, low, mid, high);

            Assert.Equal(arrExpected, sortedArr);
        }

        [Theory]
        [InlineData((new int[] { 5, 1, 100, 15, 57 }), (new int[] { 1, 5, 15, 57, 100 }))]
        [InlineData((new int[] { 5, -1, -27, 56, 231 }), (new int[] { -27, -1, 5, 56, 231 }))]
        [InlineData((new int[] { -1, -10, -50, 0, -1 }), (new int[] { -50, -10, -1, -1, 0 }))]
        public void MergeSortCanSortAnIntegerArrayInAscendingOrder(int[] arrToSort, int[] arrExpected)
        {
            int low = 0, high = arrToSort.Length - 1;

            int[] sortedArr = Program.MergeSort(arrToSort, low, high);

            Assert.Equal(arrExpected, sortedArr);
        }

    }
}
