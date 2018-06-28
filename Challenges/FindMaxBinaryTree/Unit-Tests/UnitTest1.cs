using FindMaxBinaryTree;
using System;
using Trees.Classes;
using Xunit;

namespace Unit_Tests
{
    public class UnitTest1
    {
        [Fact]
        public void CanPopulateBinaryTreeWithNodes()
        {
            BinaryTree binTree = Program.PopulateTree();

            Assert.NotNull(binTree);
        }

        [Fact]
        public void CanFindMaxNodeValueInBinaryTree()
        {
            BinaryTree binTree = Program.PopulateTree();
            int maxValue = binTree.Root.Value; // Root = 10

            Assert.Equal(10, maxValue);

            maxValue = Program.FindMax(binTree.Root, maxValue); // maxValue = 63

            Assert.Equal(63, maxValue);
        }

        [Theory]
        [InlineData(-1)]
        [InlineData(5)]
        [InlineData(100)]
        public void CanAddNodeToBinaryTree(int inputValue)
        {
            Node addedNode = new Node(inputValue);
            BinaryTree binTree = new BinaryTree(addedNode);

            Assert.Equal(binTree.Root.Value, addedNode.Value);
        }
    }
}
