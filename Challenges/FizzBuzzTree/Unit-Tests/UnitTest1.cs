using System;
using FizzBuzzTree.Classes;
using Xunit;

namespace Unit_Tests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("1")]
        [InlineData("5")]
        [InlineData("10")]
        public void CanAddNodeToBinaryTree(string inputValue)
        {
            Node addedNode = new Node(inputValue);
            BinaryTree binTree = new BinaryTree(addedNode);

            Assert.Same(binTree.Root, addedNode);
        }

        [Theory]
        [InlineData("-3", "Fizz")]
        [InlineData("3", "Fizz")]
        [InlineData("5", "Buzz")]
        [InlineData("15", "FizzBuzz")]
        public void CanConvertNodeValueToFizzBuzzValue(string inputValue, string convertedValue)
        {
            Node addedNode = new Node(inputValue);
            BinaryTree binTree = new BinaryTree(addedNode);

            Node checkedNode = binTree.CheckNode(binTree.Root);

            Assert.Equal(convertedValue, checkedNode.Value);
        }

        [Theory]
        [InlineData("1")]
        [InlineData("8")]
        [InlineData("3Hello")]
        [InlineData("Paul")]
        public void CanNotConvertNodeValueIfValueDoesNotMeetFizzBuzzRules(string inputValue)
        {
            Node addedNode = new Node(inputValue);
            BinaryTree binTree = new BinaryTree(addedNode);

            Node checkedNode = binTree.CheckNode(binTree.Root);

            Assert.Equal(inputValue, checkedNode.Value);
        }
    }
}
