using System;
using System.Collections.Generic;
using System.Text;

namespace Graphs.Classes
{
    public class Graph
    {
        public Node Root { get; set; }

        public Graph(Node root)
        {
            Root = root;
        }

        public bool AddEdge(Node root, string firstVertexValue, string secondVertexValue, int? weight)
        {
            List<Node> nodeList = GetNodes(root);

            Node firstNode = null;
            Node secondNode = null;

            // Check if Vertices exist in Graph
            for (int i = 0; i < nodeList.Count; i++)
            {
                if (nodeList[i].Value == firstVertexValue)
                {
                    firstNode = nodeList[i];
                }
                else if (nodeList[i].Value == secondVertexValue)
                {
                    secondNode = nodeList[i];
                }
            }
            
            // Create Vertices if either or both don't already exist in Graph
            if (firstNode == null && secondNode == null) // Creates an island
            {
                firstNode = new Node(firstVertexValue);
                secondNode = new Node(secondVertexValue);
            }
            else if (firstNode == null)
            {
                firstNode = new Node(firstVertexValue);
            }
            else if (secondNode == null)
            {
                secondNode = new Node(secondVertexValue);
            }

            // Create Edges between Vertices
            if (weight.HasValue)
            {
                firstNode.Edges.Add(new Edge(secondNode, (int)weight));
                secondNode.Edges.Add(new Edge(firstNode, (int)weight));
            }
            else
            {
                firstNode.Edges.Add(new Edge(secondNode));
                secondNode.Edges.Add(new Edge(firstNode));
            }

            return true;
            //return false;
        }

        public List<Node> GetNodes(Node root)
        {
            List<Node> allNodes = new List<Node>();

            Stack<Node> stack = new Stack<Node>();
            stack.Push(root);

            while (stack.TryPeek(out root))
            {
                Node top = stack.Pop();
                top.Visited = true;
                allNodes.Add(top);

                foreach (Edge edge in top.Edges)
                {
                    if (!edge.Target.Visited)
                    {
                        edge.Target.Visited = true;
                        stack.Push(edge.Target);
                    }
                }
            }

            foreach (Node node in allNodes)
            {
                node.Visited = false;
            }

            return allNodes;
        }

        public List<Node> GetNeighbors(Node targetNode)
        {
            List<Node> neighborList = new List<Node>();

            foreach (Edge edge in targetNode.Edges)
            {
                neighborList.Add(edge.Target);
            }

            return neighborList;
        }

        public int Size(Node root)
        {
            List<Node> nodeList = new List<Node>();
            int nodeCount = 0;

            Queue<Node> bfQueue = new Queue<Node>();
            bfQueue.Enqueue(root);

            while (bfQueue.TryPeek(out root))
            {
                Node front = bfQueue.Dequeue();
                front.Visited = true;
                nodeList.Add(front);

                foreach (Edge edge in front.Edges)
                {
                    if (!edge.Target.Visited)
                    {
                        edge.Target.Visited = true;
                        bfQueue.Enqueue(edge.Target);
                    }
                }
            }

            foreach (Node node in nodeList)
            {
                nodeCount++;
                node.Visited = false;
            }

            return nodeCount;
        }

        public List<Node> BreadthFirst(Node root)
        {
            List<Node> orderedList = new List<Node>();

            Queue<Node> bfQueue = new Queue<Node>();
            bfQueue.Enqueue(root);

            while (bfQueue.TryPeek(out root))
            {
                Node front = bfQueue.Dequeue();
                front.Visited = true;
                orderedList.Add(front);

                foreach (Edge edge in front.Edges)
                {
                    if (!edge.Target.Visited)
                    {
                        edge.Target.Visited = true;
                        bfQueue.Enqueue(edge.Target);
                    }
                }
            }

            foreach (Node node in orderedList)
            {
                node.Visited = false;
            }

            return orderedList;
        }
    }
}
