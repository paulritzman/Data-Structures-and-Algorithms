using Graphs.Classes;
using System;
using System.Collections.Generic;

namespace Graphs
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Graph graph = SetUpGraph();

            ShowSize(graph);

            ShowGetNeighbors(graph);

            ShowGetNodes(graph);

            ShowBreadthFirst(graph);

            AddAdditionalEdge(graph);
        }

        public static Graph SetUpGraph()
        {
            Node firstNode = new Node("1");
            Node secondNode = new Node("2");
            Node thirdNode = new Node("3");
            Node fourthNode = new Node("4");
            Node fifthNode = new Node("5");

            Graph graph = new Graph(firstNode);

            graph.AddEdge(graph.Root, firstNode.Value, secondNode.Value, null);
            graph.AddEdge(graph.Root, firstNode.Value, thirdNode.Value, null);
            graph.AddEdge(graph.Root, secondNode.Value, thirdNode.Value, null);
            graph.AddEdge(graph.Root, thirdNode.Value, fourthNode.Value, null);
            graph.AddEdge(graph.Root, fourthNode.Value, fifthNode.Value, null);

            return graph;
        }

        public static void ShowSize(Graph graph)
        {
            int numVertices = graph.Size(graph.Root);

            Console.WriteLine($"Size of Graph: {numVertices}\n");
        }

        public static void ShowGetNeighbors(Graph graph)
        {
            Console.WriteLine("GetNeighbors()");

            List<Node> nodeList = graph.GetNodes(graph.Root);

            foreach (Node n in nodeList)
            {
                Console.Write($"{n.Value}:");

                List<Node> neighborList = graph.GetNeighbors(n);

                foreach (Node neighbor in neighborList)
                {
                    Console.Write($" {neighbor.Value}");
                }

                Console.WriteLine();
            }

            Console.WriteLine();
        }

        public static void ShowGetNodes(Graph graph)
        {
            Console.WriteLine("GetNodes()");

            List<Node> nodeList = graph.GetNodes(graph.Root);

            foreach (Node n in nodeList)
            {
                Console.Write($"{n.Value} ");
            }

            Console.WriteLine("\n");
        }

        public static void ShowBreadthFirst(Graph graph)
        {
            Console.WriteLine("BreadthFirst()");

            List<Node> nodeList = graph.BreadthFirst(graph.Root);

            foreach (Node n in nodeList)
            {
                Console.Write($"{n.Value} ");
            }

            Console.WriteLine("\n");
        }

        public static void AddAdditionalEdge(Graph graph)
        {
            Console.WriteLine("Adding an Edge between \"Node 1\" and \"Node 5\".\n");

            graph.AddEdge(graph.Root, "1", "5", null);

            ShowGetNeighbors(graph);
        }
    }
}
