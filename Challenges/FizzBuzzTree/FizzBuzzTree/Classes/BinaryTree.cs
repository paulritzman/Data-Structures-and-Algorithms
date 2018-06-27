using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzzTree.Classes
{
    class BinaryTree
    {
        /// <summary>
        /// Declares Class fields - provides getters and setters
        /// </summary>
        public Node Root { get; set; }

        /// <summary>
        /// Constructor method for creating a Binary Tree
        /// </summary>
        /// <param name="value">Node</param>
        public BinaryTree(Node root)
        {
            Root = root;
        }

        /// <summary>
        /// Method which adds a Node to the Binary Tree
        /// </summary>
        /// <param name="root">Node</param>
        /// <param name="newNode">Node</param>
        public void Add(Node root, Node newNode)
        {
            Queue<Node> bfQueue = new Queue<Node>();
            bfQueue.Enqueue(root);

            while (bfQueue.TryPeek(out root))
            {
                Node front = bfQueue.Dequeue();

                if (front.LeftChild != null)
                {
                    bfQueue.Enqueue(front.LeftChild);
                }
                else
                {
                    front.LeftChild = newNode;
                    return;
                }

                if (front.RightChild != null)
                {
                    bfQueue.Enqueue(front.RightChild);
                }
                else
                {
                    front.RightChild = newNode;
                    return;
                }
            }
        }

        public Node ConvertToFizzBuzz(Node root)
        {
            CheckNode(root);

            if (root.LeftChild != null)
            {
                ConvertToFizzBuzz(root.LeftChild);
            }

            if (root.RightChild != null)
            {
                ConvertToFizzBuzz(root.RightChild);
            }

            return root;
        }

        /// <summary>
        /// Helper method for checking the Value of a Node. Changes Value to "Fizz", "Buzz", or "FizzBuzz"
        /// based on divisibility.
        /// </summary>
        /// <param name="nodeToCheck">Node</param>
        /// <returns>Node</returns>
        public Node CheckNode(Node nodeToCheck)
        {
            int.TryParse(nodeToCheck.Value, out int result);

            if (result == 0)
            {
                return nodeToCheck;
            }

            if (result % 15 == 0)
            {
                nodeToCheck.Value = "FizzBuzz";
            }
            else if (result % 5 == 0)
            {
                nodeToCheck.Value = "Buzz";
            }
            else if (result % 3 == 0)
            {
                nodeToCheck.Value = "Fizz";
            }

            return nodeToCheck;
        }

        /// <summary>
        /// Method which prints the Nodes in a Binary Tree in "Preorder" (Depth First) sequence
        /// </summary>
        /// <param name="node">root Node</param>
        public void PreOrder(Node node)
        {
            Console.Write($"{node.Value} ");

            if (node.LeftChild != null)
            {
                PreOrder(node.LeftChild);
            }

            if (node.RightChild != null)
            {
                PreOrder(node.RightChild);
            }
        }

        /// <summary>
        /// Method which prints the Nodes in a Binary Tree in "Inorder" (Depth First) sequence
        /// </summary>
        /// <param name="node">root Node</param>
        public void InOrder(Node node)
        {
            if (node.LeftChild != null)
            {
                InOrder(node.LeftChild);
            }

            Console.Write($"{node.Value} ");

            if (node.RightChild != null)
            {
                InOrder(node.RightChild);
            }
        }

        /// <summary>
        /// Method which prints the Nodes in a Binary Tree in "Postorder" (Depth First) sequence
        /// </summary>
        /// <param name="node">root Node</param>
        public void PostOrder(Node node)
        {
            if (node.LeftChild != null)
            {
                PostOrder(node.LeftChild);
            }

            if (node.RightChild != null)
            {
                PostOrder(node.RightChild);
            }

            Console.Write($"{node.Value} ");
        }

        /// <summary>
        /// Method which prints the Nodes in a Binary Tree in "Breadth First" sequence
        /// </summary>
        /// <param name="node">root Node</param>
        public void BreadthFirst(Node root)
        {
            Queue<Node> bfQueue = new Queue<Node>();
            bfQueue.Enqueue(root);

            while (bfQueue.TryPeek(out root))
            {
                Node front = bfQueue.Dequeue();
                Console.Write($"{front.Value} ");

                if (front.LeftChild != null)
                {
                    bfQueue.Enqueue(front.LeftChild);
                }

                if (front.RightChild != null)
                {
                    bfQueue.Enqueue(front.RightChild);
                }
            }
        }

    }
}
