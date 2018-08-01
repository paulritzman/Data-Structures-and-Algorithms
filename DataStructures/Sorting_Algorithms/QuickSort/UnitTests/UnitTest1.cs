using Quick;
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
        [InlineData((new int[] { 5, 1, 100 }), (new int[] { 100, 1, 5 }))]
        public void SwapValuesCanFlipTheIndexesOfElementsInAnArray(int[] arrToFlip, int[] arrExpected)
        {
            int left = 0, right = arrToFlip.Length - 1;

            Program.SwapValues(arrToFlip, left, right);

            Assert.Equal(arrExpected, arrToFlip);
        }

        [Theory]
        [InlineData((new int[] { 5, 1, 100, 15, 57 }), (new int[] { 5, 1, 57, 15, 100 }))]
        [InlineData((new int[] { 5, -1, -27, 56, 231 }), (new int[] { -27, -1, 5, 56, 231 }))]
        [InlineData((new int[] { 34, 19, 42, -9, 2018, 0, 2005, 77, 2099 }), (new int[] { 34, 19, 42, -9, 77, 0, 2005, 2018, 2099 }))]
        public void PartitionCanPlaceAllElementsSmallerThanMiddleElementOnLeftAndAllLargerElementsOnRight (int[] arrToPartition, int[] arrExpected)
        {
            int left = 0, right = arrToPartition.Length - 1;

            Program.Partition(arrToPartition, left, right);

            Assert.Equal(arrExpected, arrToPartition);
        }

        [Theory]
        [InlineData((new int[] { 5, 1, 100, 15, 57 }), (new int[] { 1, 5, 15, 57, 100 }))]
        [InlineData((new int[] { 5, -1, -27, 56, 231 }), (new int[] { -27, -1, 5, 56, 231 }))]
        [InlineData((new int[] { 34, 19, 42, -9, 2018, 0, 2005, 77, 2099 }), (new int[] { -9, 0, 19, 34, 42, 77, 2005, 2018, 2099 }))]
        public void QuickSortCanSortAnIntegerArrayInAscendingOrder(int[] arrToSort, int[] arrExpected)
        {
            int left = 0, right = arrToSort.Length - 1;

            Program.QuickSort(arrToSort, left, right);

            Assert.Equal(arrExpected, arrToSort);
        }
    }
}
