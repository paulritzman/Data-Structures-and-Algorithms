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
            if (root == null)
            {
                root = newNode;
                return;
            }

            while (root != null)
            {

                if (root.Value == newNode.Value)
                {
                    Console.WriteLine($"{newNode.Value} already exists in the Binary Search Tree.");
                    return;
                }

                if (root.Value > newNode.Value)
                {
                    if (root.LeftChild == null)
                    {
                        root.LeftChild = newNode;
                        return;
                    }
                    {
                        root = root.LeftChild;
                    }
                }
                else if (root.Value < newNode.Value)
                {
                    if (root.RightChild == null)
                    {
                        root.RightChild = newNode;
                        return;
                    }
                    {
                        root = root.RightChild;
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
            while (root != null)
            {
                Console.WriteLine(root.Value);

                if (root.Value == value)
                {
                    return root;
                }
                else if (root.Value > value)
                {
                    root = root.LeftChild;
                }
                else if (root.Value < value)
                {
                    root = root.RightChild;
                }
            }

            return null;
        }
    }
}
