using System;
using LLKthElementFromEnd;
using LLKthElementFromEnd.Classes;
using Xunit;

namespace Unit_Tests
{
    public class UnitTest1
    {
        [Fact]
        public void CanAddNewNode()
        {
            LinkedList ll = new LinkedList(new Node("5"));

            Node node2 = new Node("10");
            ll.AddNode(node2);

            Assert.Equal(ll.Head.Value, node2.Value);
        }

        [Theory]
        [InlineData("1", "1")]
        [InlineData("5", "5")]
        [InlineData("9", "9")]
        public void CanVerifyKDistanceInput_Valid(string expected, string kInput)
        {
            Assert.Equal(expected, Program.VerifyKDistance(kInput).ToString());
        }

        [Theory]
        [InlineData("-1", "-1")]
        [InlineData("-1", "asdf")]
        [InlineData("-1", "1a2b3c")]
        public void CanVerifyKDistanceInput_Invalid(string expected, string kInput)
        {
            Assert.Equal(expected, Program.VerifyKDistance(kInput).ToString());
        }

        [Theory]
        [InlineData("5", 0)]
        [InlineData("10", 1)]
        [InlineData("16", 2)]
        [InlineData("25", 3)]
        public void CanFindKthNodeFromEnd(string expected, int distanceFromEnd)
        {
            LinkedList ll = new LinkedList(new Node("5"));
            Node node2 = new Node("10");
            Node node3 = new Node("16");
            Node node4 = new Node("25");
            ll.AddNode(node2);
            ll.AddNode(node3);
            ll.AddNode(node4);

            Node found = ll.KthElement(distanceFromEnd);

            Assert.Equal(expected, found.Value);
        }

        [Theory]
        [InlineData(-1)]
        [InlineData(15)]
        [InlineData(100)]
        [InlineData(1234)]
        public void CanReturnExceptionForKDistanceOutsideOfRange(int distanceFromEnd)
        {
            LinkedList ll = new LinkedList(new Node("5"));
            Node node2 = new Node("10");
            Node node3 = new Node("16");
            Node node4 = new Node("25");
            ll.AddNode(node2);
            ll.AddNode(node3);
            ll.AddNode(node4);

            Assert.Throws<IndexOutOfRangeException>(() => ll.KthElement(distanceFromEnd));
        }
    }
}
