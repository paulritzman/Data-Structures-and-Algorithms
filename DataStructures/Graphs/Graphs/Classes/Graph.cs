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
            return null;
        }

        public List<Node> GetNeighbors(Node root)
        {
            return null;
        }

        public int Size(Node root)
        {
            return 0;
        }

        public List<Node> BreadthFirst(Node root)
        {
            List<Node> nodeList = new List<Node>();

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
                node.Visited = false;
            }

            return nodeList;
        }
    }
}
