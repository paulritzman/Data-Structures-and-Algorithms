using System;
using System.Collections.Generic;
using System.Text;

namespace LLKthElementFromEnd.Classes
{
    class LinkedList
    {
        // LinkedList properties
        public Node Head { get; set; }
        public Node Current { get; set; }
        public Node Runner { get; set; }

        // LinkedList Constructor
        public LinkedList(Node node)
        {
            Head = node;
            Current = node;
            Runner = node;
        }

        /// <summary>
        /// Method which adds a new Node to the beginning of the Linked List.
        /// </summary>
        /// <param name="node">new Node to add to Linked List</param>
        public void AddNode(Node node)
        {
            node.Next = Head;
            Head = node;
            Current = Head;
        }

        /// <summary>
        /// Method used to generate a Linked List and populate it with 10 Nodes
        /// </summary>
        /// <returns>Linked List</returns>
        public LinkedList CreateLinkedList()
        {
            LinkedList ll = new LinkedList(new Node("10"));

            for (int i = 9; i > 0; i--)
            {
                ll.AddNode(new Node($"{i}"));
            }

            return ll;
        }

        /// <summary>
        /// Method which prints the Value of each Node in the Linked List
        /// </summary>
        public void PrintLinkedList()
        {
            Current = Head;

            while (Current.Next != null)
            {
                Console.Write($"{Current.Value} --> ");
                Current = Current.Next;
            }

            Console.Write($"{Current.Value} [End of Linked List]\n");
        }

        /// <summary>
        /// Method which locates the Node "k" distance from the end of a Linked List
        /// </summary>
        /// <param name="k">integer distance from end of Linked List</param>
        /// <returns>Node</returns>
        public Node KthElement(int k)
        {
            Current = Head;
            Runner = Head;

            if (k < 0)
            {
                throw new IndexOutOfRangeException();
            }

            int count = 0;
            while (Runner.Next != null)
            {
                if (count >= k)
                {
                    Current = Current.Next;
                }
                Runner = Runner.Next;
                count++;
            }

            return (k - count > 0) ? throw new IndexOutOfRangeException() : Current;
        }
    }
}
