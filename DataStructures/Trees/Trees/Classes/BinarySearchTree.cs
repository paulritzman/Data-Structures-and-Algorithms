using System;
using System.Collections.Generic;
using System.Text;

namespace Trees.Classes
{
    public class BinarySearchTree
    {
        public Node Root { get; set; }

        public BinarySearchTree(Node root)
        {
            Root = root;
        }

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
