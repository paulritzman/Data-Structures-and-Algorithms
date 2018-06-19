using System;
using LinkedLists;
using LinkedLists.Classes;
using static LinkedLists.Program;
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
        [InlineData("5", "5")]
        [InlineData("10", "10")]
        [InlineData("Hello", "Hello")]
        [InlineData("World", "World")]
        [InlineData("!!!", "!!!")]
        public void CanFindExistingNode(string expected, string value)
        {
            LinkedList ll = new LinkedList(new Node("5"));

            Node node2 = new Node("10");
            Node node3 = new Node("Hello");
            Node node4 = new Node("World");
            Node node5 = new Node("!!!");
            ll.AddNode(node2);
            ll.AddNode(node3);
            ll.AddNode(node4);
            ll.AddNode(node5);

            Node found = ll.Find(value);

            Assert.Equal(expected, found.Value);
        }

        [Theory]
        [InlineData("-5")]
        [InlineData("100")]
        [InlineData("Hi")]
        [InlineData("Earth")]
        [InlineData("...")]
        public void CanReturnNullForNodeThatDoesNotExist(string value)
        {
            LinkedList ll = new LinkedList(new Node("5"));

            Node node2 = new Node("10");
            Node node3 = new Node("Hello");
            Node node4 = new Node("World");
            Node node5 = new Node("!!!");
            ll.AddNode(node2);
            ll.AddNode(node3);
            ll.AddNode(node4);
            ll.AddNode(node5);

            Node found = ll.Find(value);

            Assert.Null(found);
        }


    }
}
