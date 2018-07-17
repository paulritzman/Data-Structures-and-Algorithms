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

        [Fact]
        public void SizeCanReturnTotalNumberOfNodesInGraph()
        {
            Node firstNode = new Node("1");
            Graph graph = new Graph(firstNode);

            Node secondNode = new Node("2");
            Node thirdNode = new Node("3");
            Node fourthNode = new Node("4");
            Node fifthNode = new Node("5");

            firstNode.Neighbors.Add(secondNode);
            firstNode.Neighbors.Add(thirdNode);
            firstNode.Neighbors.Add(fourthNode);
            firstNode.Neighbors.Add(fifthNode);
            
            int numberOfNodes = graph.Size(graph.Root);

            Assert.Equal(5, numberOfNodes);
        }

        [Fact]
        public void GetNodesCanReturnAllNodesInGraph()
        {
            Node firstNode = new Node("1");
            Graph graph = new Graph(firstNode);

            Node secondNode = new Node("2");
            Node thirdNode = new Node("3");
            Node fourthNode = new Node("4");
            Node fifthNode = new Node("5");

            firstNode.Neighbors.Add(secondNode);
            secondNode.Neighbors.Add(thirdNode);
            thirdNode.Neighbors.Add(fourthNode);
            fourthNode.Neighbors.Add(fifthNode);

            var nodeList = graph.GetNodes(graph.Root);

            Assert.Contains(firstNode, nodeList);
            Assert.Contains(secondNode, nodeList);
            Assert.Contains(thirdNode, nodeList);
            Assert.Contains(fourthNode, nodeList);
            Assert.Contains(fifthNode, nodeList);
        }

        [Fact]
        public void BreadthFirstCanReturnAllNodesInGraph()
        {
            Node firstNode = new Node("1");
            Graph graph = new Graph(firstNode);

            Node secondNode = new Node("2");
            Node thirdNode = new Node("3");
            Node fourthNode = new Node("4");
            Node fifthNode = new Node("5");

            firstNode.Neighbors.Add(secondNode);
            secondNode.Neighbors.Add(thirdNode);
            thirdNode.Neighbors.Add(fourthNode);
            fourthNode.Neighbors.Add(fifthNode);

            var nodeList = graph.BreadthFirst(graph.Root);

            Assert.Contains(firstNode, nodeList);
            Assert.Contains(secondNode, nodeList);
            Assert.Contains(thirdNode, nodeList);
            Assert.Contains(fourthNode, nodeList);
            Assert.Contains(fifthNode, nodeList);
        }

        [Theory]
        [InlineData("1", "2")]
        [InlineData("3", "7")]
        [InlineData("Hello", "Goodbye")]
        public void AddEdgeCanCreateLinkBetweenExistingNodesInGraph(string parentNodeValue, string childNodeValue)
        {
            Node firstNode = new Node(parentNodeValue);
            Node secondNode = new Node("middle");
            Node thirdNode = new Node(childNodeValue);

            Graph graph = new Graph(firstNode);

            // Create edges between all Nodes except between firstNode and thirdNode
            firstNode.Neighbors.Add(secondNode);
            secondNode.Neighbors.Add(firstNode);
            secondNode.Neighbors.Add(thirdNode);
            thirdNode.Neighbors.Add(secondNode);
            
            // Add edge between firstNode and thirdNode
            bool wereLinked = graph.AddEdge(graph.Root, parentNodeValue, childNodeValue);

            Assert.Contains(secondNode, firstNode.Neighbors);
            Assert.Contains(firstNode, secondNode.Neighbors);
            Assert.True(wereLinked);
        }

        [Theory]
        [InlineData("1", "2")]
        [InlineData("3", "7")]
        [InlineData("Hello", "Goodbye")]
        public void AddEdgeCanCreateLinkBetweenNonExistingNodesInGraph(string parentNodeValue, string childNodeValue)
        {
            Node firstNode = new Node("first");
            Graph graph = new Graph(firstNode);

            bool wereLinked = graph.AddEdge(graph.Root, parentNodeValue, childNodeValue);

            Assert.True(wereLinked);
        }

        [Theory]
        [InlineData("1", null)]
        [InlineData(null, "7")]
        [InlineData("Hello", null)]
        public void AddEdgeCanCreateLinkBetweenOneNonExistingNodeInGraph(string parentNodeValue, string childNodeValue)
        {
            Node firstNode = new Node("first");
            Graph graph = new Graph(firstNode);

            bool wereLinked = false;
            
            if (string.IsNullOrEmpty(parentNodeValue))
            {
                Node secondNode = new Node(parentNodeValue);

                firstNode.Neighbors.Add(secondNode);
                secondNode.Neighbors.Add(firstNode);

                wereLinked = graph.AddEdge(graph.Root, parentNodeValue, childNodeValue);
            }
            else if (string.IsNullOrEmpty(childNodeValue))
            {
                Node thirdNode = new Node(childNodeValue);

                firstNode.Neighbors.Add(thirdNode);
                thirdNode.Neighbors.Add(firstNode);

                wereLinked = graph.AddEdge(graph.Root, parentNodeValue, childNodeValue);
            }
            
            Assert.True(wereLinked);
        }
        
        [Theory]
        [InlineData("-1")]
        [InlineData("1")]
        [InlineData("Hello")]
        public void GetNeighborsCanReturnAllNeighboringNodesOfAGivenTargetNode(string targetNodeValue)
        {
            Node targetNode = new Node(targetNodeValue);
            Graph graph = new Graph(targetNode);

            Node firstNeighbor = new Node("first");
            Node secondNeighbor = new Node("second");
            Node thirdNeighbor = new Node("third");

            targetNode.Neighbors.Add(firstNeighbor);
            targetNode.Neighbors.Add(secondNeighbor);
            targetNode.Neighbors.Add(thirdNeighbor);

            var neighborList = graph.GetNeighbors(targetNode);

            Assert.Contains(firstNeighbor, neighborList);
            Assert.Contains(secondNeighbor, neighborList);
            Assert.Contains(thirdNeighbor, neighborList);
        }
    }
}
