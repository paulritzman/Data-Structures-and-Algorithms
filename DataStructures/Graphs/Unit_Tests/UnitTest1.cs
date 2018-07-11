using System;
using Xunit;
using Graphs.Classes;

namespace Unit_Tests
{
    public class UnitTest1
    {
        [Fact]
        public void CanCreateGraphWithARootNode()
        {
            Node newNode = new Node("1");
            Graph graph = new Graph(newNode);

            Assert.Equal("1", graph.Root.Value);
        }

        [Theory]
        [InlineData("1", "2")]
        [InlineData("3", "7")]
        [InlineData("Hello", "Goodbye")]
        public void CanAddEdgeBetweenNodesInGraph(string parentNodeValue, string childNodeValue)
        {
            Node firstNode = new Node(parentNodeValue);
            Graph graph = new Graph(firstNode);

            Node secondNode = new Node(childNodeValue);
            graph.AddEdge(graph.Root, firstNode, secondNode);

            Assert.Contains(secondNode, firstNode.Neighbors);
            Assert.Contains(firstNode, secondNode.Neighbors);
        }
    }
}
