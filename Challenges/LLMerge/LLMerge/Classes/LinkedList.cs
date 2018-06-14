using System;
using System.Collections.Generic;
using System.Text;

namespace LLMerge.Classes
{
    public class LinkedList
    {
        // LinkedList properties
        public Node Head { get; set; }
        public Node Current { get; set; }

        // LinkedList Constructor
        public LinkedList(Node node)
        {
            Head = node;
            Current = node;
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
        /// Method which takes in two Linked Lists as parameters and merges them into the first Linked List
        /// passed in. Nodes in merged Linked List alternate between the first and second Linked Lists.
        /// </summary>
        /// <param name="LL1">Linked List</param>
        /// <param name="LL2">Linked List</param>
        /// <returns>Reference to the Head of the merged Linked List</returns>
        public Node MergeLists(LinkedList LL1, LinkedList LL2)
        {
            Node RefNode1 = LL1.Head;
            Node RefNode2 = LL2.Head;
            LL1.Current = LL1.Head;
            LL2.Current = LL2.Head;

            while ((LL1.Current.Next != null) && (LL2.Current.Next != null))
            {
                RefNode1 = LL1.Current.Next;
                RefNode2 = LL2.Current.Next;

                LL1.Current.Next = LL2.Current;
                LL2.Current.Next = RefNode1;

                LL1.Current = RefNode1;
                LL2.Current = RefNode2;
            }

            if ((LL2.Current.Next == null) && (LL1.Current.Next != null))
            {
                LL2.Current.Next = LL1.Current.Next;
                LL1.Current.Next = LL2.Current;
            }
            else
            {
                LL1.Current.Next = LL2.Current;
            }

            return LL1.Head;
        }

    }
}
