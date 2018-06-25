using System;
using Trees.Classes;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(1)]
        [InlineData(5)]
        [InlineData(10)]
        public void CanAddNodeToBinarySearchTree(int inputValue)
        {
            Node addedNode = new Node(inputValue);
            BinarySearchTree binSearchTree = new BinarySearchTree(addedNode);

            Assert.Same(binSearchTree.Root, addedNode);
        }

        [Theory]
        [InlineData(1)]
        [InlineData(20)]
        [InlineData(50)]
        public void CanSearchForAndReturnANodeFromBinarySearchTree(int inputValue)
        {
            BinarySearchTree binSearchTree = new BinarySearchTree(new Node(15));
            binSearchTree.Add(binSearchTree.Root, new Node(4));
            binSearchTree.Add(binSearchTree.Root, new Node(5));
            binSearchTree.Add(binSearchTree.Root, new Node(17));
            binSearchTree.Add(binSearchTree.Root, new Node(25));
            binSearchTree.Add(binSearchTree.Root, new Node(inputValue));

            Node foundNode = binSearchTree.Search(binSearchTree.Root, inputValue);

            Assert.Equal(inputValue, foundNode.Value);
        }

        [Theory]
        [InlineData(1)]
        [InlineData(20)]
        [InlineData(50)]
        public void CanSearchForAndReturnNodeFromBinaryTree(int inputValue)
        {
            BinaryTree binTree = new BinaryTree(new Node(15));
            binTree.Add(binTree.Root, new Node(4));
            binTree.Add(binTree.Root, new Node(5));
            binTree.Add(binTree.Root, new Node(17));
            binTree.Add(binTree.Root, new Node(25));
            binTree.Add(binTree.Root, new Node(inputValue));

            Node foundNode = binTree.Search(binTree.Root, inputValue);

            Assert.Equal(inputValue, foundNode.Value);
        }
    }
}
