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

        public void AddEdge(Node root, Node parentNode, Node newNode)
        {
            Queue<Node> bfQueue = new Queue<Node>();
            bfQueue.Enqueue(root);

            while (bfQueue.TryPeek(out root))
            {
                Node front = bfQueue.Dequeue();
                
                if (front.Value == parentNode.Value)
                {
                    front.Neighbors.Add(newNode);
                    newNode.Neighbors.Add(front);
                    return;
                }

                foreach (Node neighbor in front.Neighbors)
                {
                    if (!neighbor.Visited)
                    {
                        neighbor.Visited = true;
                        bfQueue.Enqueue(neighbor);
                    }
                }
            }
        }

        public List<Node> GetNodes(Node root)
        {
            List<Node> allNodes = new List<Node>();

            Stack<Node> stack = new Stack<Node>();
            stack.Push(root);

            while (stack.TryPeek(out root))
            {
                Node top = stack.Pop();
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
