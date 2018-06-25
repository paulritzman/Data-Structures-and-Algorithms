using System;
using System.Collections.Generic;
using System.Text;

namespace Trees.Classes
{
    public class BinarySearchTree
    {
        /// <summary>
        /// Declares Class fields - provides getters and setters
        /// </summary>
        public Node Root { get; set; }

        /// <summary>
        /// Constructor method for creating a Binary Search Tree
        /// </summary>
        /// <param name="value">Node</param>
        public BinarySearchTree(Node root)
        {
            Root = root;
        }

        /// <summary>
        /// Method which adds a Node to the Binary Search Tree
        /// </summary>
        /// <param name="root">root Node</param>
        /// <param name="newNode">Node</param>
        public void Add(Node root, Node newNode)
        {
            Queue<Node> bSearchQueue = new Queue<Node>();
            bSearchQueue.Enqueue(root);

            while (bSearchQueue.TryPeek(out root))
            {
                Node front = bSearchQueue.Dequeue();

                if (front.Value == newNode.Value)
                {
                    Console.WriteLine($"{newNode.Value} already exists in the Binary Search Tree.");
                    return;
                }

                if (front.Value > newNode.Value)
                {
                    if (front.LeftChild == null)
                    {
                        front.LeftChild = newNode;
                        return;
                    }
                    else if (front.LeftChild.Value < newNode.Value)
                    {
                        newNode.LeftChild = front.LeftChild;
                        front.LeftChild = newNode;
                        return;
                    }
                    else
                    {
                        bSearchQueue.Enqueue(front.LeftChild);
                    }
                }

                if (front.Value < newNode.Value)
                {
                    if (front.RightChild == null)
                    {
                        front.RightChild = newNode;
                        return;
                    }
                    else if (front.RightChild.Value > newNode.Value)
                    {
                        newNode.RightChild = front.RightChild;
                        front.RightChild = newNode;
                        return;
                    }
                    else
                    {
                        bSearchQueue.Enqueue(front.RightChild);
                    }
                }
            }
        }

        /// <summary>
        /// Method which locates a Node with the specified Value within the Binary Search Tree
        /// </summary>
        /// <param name="root">root Node</param>
        /// <param name="value">Value of Node to search for</param>
        /// <returns>Node</returns>
        public Node Search(Node root, int value)
        {
            Queue<Node> bSearchQueue = new Queue<Node>();
            bSearchQueue.Enqueue(root);

            while (bSearchQueue.TryPeek(out root))
            {
                Node front = bSearchQueue.Dequeue();
                Console.WriteLine(front.Value);

                if (front.Value == value)
                {
                    return front;
                }
                
                if (front.Value > value)
                {
                    bSearchQueue.Enqueue(front.LeftChild);
                }

                if (front.Value < value)
                {
                    bSearchQueue.Enqueue(front.RightChild);
                }
            }
            
            return null;
        }
    }
}
