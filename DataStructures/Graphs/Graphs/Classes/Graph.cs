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

        public bool AddEdge(Node root, string firstVertexValue, string secondVertexValue)
        {
            List<Node> nodeList = GetNodes(root);

            Node firstNode = null;
            Node secondNode = null;

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

            if (firstNode != null && secondNode != null)
            {
                firstNode.Neighbors.Add(secondNode);
                secondNode.Neighbors.Add(firstNode);

                return true;
            }
            else if (firstNode == null && secondNode == null)
            {
                firstNode = new Node(firstVertexValue);
                secondNode = new Node(secondVertexValue);

                root.Neighbors.Add(firstNode);
                root.Neighbors.Add(secondNode);

                firstNode.Neighbors.Add(root);
                firstNode.Neighbors.Add(secondNode);

                secondNode.Neighbors.Add(root);
                secondNode.Neighbors.Add(firstNode);

                return true;
            }
            else if (firstNode == null)
            {
                firstNode = new Node(firstVertexValue);

                root.Neighbors.Add(firstNode);
                secondNode.Neighbors.Add(firstNode);

                firstNode.Neighbors.Add(root);
                firstNode.Neighbors.Add(secondNode);

                return true;
            }
            else if (secondNode == null)
            {
                secondNode = new Node(secondVertexValue);

                root.Neighbors.Add(secondNode);
                firstNode.Neighbors.Add(secondNode);

                secondNode.Neighbors.Add(root);
                secondNode.Neighbors.Add(firstNode);

                return true;
            }

            return false;
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

                foreach (Node neighbor in top.Neighbors)
                {
                    if (!neighbor.Visited)
                    {
                        neighbor.Visited = true;
                        stack.Push(neighbor);
                    }
                }
            }

            foreach (Node node in allNodes)
            {
                node.Visited = false;
            }

            return allNodes;
        }

        public List<Node> GetNeighbors(Node target)
        {
            return target.Neighbors;
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

                foreach (Node neighbor in front.Neighbors)
                {
                    if (!neighbor.Visited)
                    {
                        neighbor.Visited = true;
                        bfQueue.Enqueue(neighbor);
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

                foreach (Node neighbor in front.Neighbors)
                {
                    if (!neighbor.Visited)
                    {
                        neighbor.Visited = true;
                        bfQueue.Enqueue(neighbor);
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
