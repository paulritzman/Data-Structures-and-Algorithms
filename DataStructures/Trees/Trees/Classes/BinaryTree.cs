using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Trees.Classes
{
    public class BinaryTree
    {
        public Node Root { get; set; }
        
        public BinaryTree(Node root)
        {
            Root = root;
        }

        public virtual void Add(Node root, Node newNode)
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

        public virtual Node Search(Node root, int value)
        {
            Queue<Node> bfQueue = new Queue<Node>();
            bfQueue.Enqueue(root);

            while (bfQueue.TryPeek(out root))
            {
                Node front = bfQueue.Dequeue();

                if (front.Value == value)
                {
                    return front;
                }

                if (front.LeftChild != null)
                {
                    bfQueue.Enqueue(front.LeftChild);
                }

                if (front.RightChild != null)
                {
                    bfQueue.Enqueue(front.RightChild);
                }
            }

            return null;
        }

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
