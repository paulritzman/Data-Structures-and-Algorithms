using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedLists.Classes
{
    public class LinkedList
    {
        public Node Head { get; set; }
        public Node Current { get; set; }

        public LinkedList(Node node)
        {
            Head = node;
            Current = node;
        }

        // O(1) - Add Node Beginning - adds a node to the front of the linked list
        public void AddNode(Node node)
        {
            Current = Head;
            node.Next = Head;
            Head = node;
            Current = Head;
        }

        // O(n) - Add Node Before - Adds a node before an existing node
        public uint AddBefore (Node newNode, Node existingNode)
        {
            // Reset Current to the beginning of the linked list
            Current = Head;
            
            // Handles situations where existingNode references the first node in the linked list
            // Also handles situations where existingNode is the only node in the linked list
            if (Head.Value == existingNode.Value)
            {
                try
                {
                    AddNode(newNode);
                    return 1;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Something went wrong, unable to add node to linked list.");
                    Console.WriteLine(e.Message);
                    return 0;
                }
            }

            while (Current.Next != null)
            {
                if (Current.Next.Value == existingNode.Value)
                {
                    try
                    {
                        newNode.Next = existingNode;
                        Current.Next = newNode;
                        return 1;
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Something went wrong, unable to add node to linked list.");
                        Console.WriteLine(e.Message);
                        return 0;
                    }
                }

                Current = Current.Next;
            }

            return 0;
        }

        // O(n) - Add Node After - Adds a node after an existing node
        public uint AddAfter(Node newNode, Node existingNode)
        {
            Current = Head;

            while (Current.Next != null)
            {
                if (Current.Value == existingNode.Value)
                {
                    newNode.Next = existingNode.Next;
                    Current.Next = newNode;
                    return 1;
                }
                Current = Current.Next;
            }

            return 0;
        }

        // O(n) - Add Node Last - Adds a node to the end of a linked list
        public uint AddLast(Node newNode)
        {
            Current = Head;

            while (Current.Next != null)
            {
                Current = Current.Next;
            }

            try
            {
                Current.Next = newNode;
                return 1;
            }
            catch (Exception e)
            {
                Console.WriteLine("Something went wrong, unable to add node to linked list.");
                Console.WriteLine(e.Message);
                return 0;
            }
        }

        // O(n) - Find Value - Finds a specific value in the linked list
        public Node Find(string value)
        {
            Current = Head;

            while (Current.Next != null)
            {
                if (Current.Value == value)
                {
                    return Current;
                }
                Current = Current.Next;
            }

            return (Current.Value == value) ? Current : null;
        }

        // O(n) - Print Nodes - Prints out all of the values in the linked list
        public void PrintNodes()
        {
            Current = Head;
            
            while(Current.Next != null)
            {
                Console.Write($"{Current.Value} --> ");
                Current = Current.Next;
            }

            Console.WriteLine($"{Current.Value} (End of Linked List)");
        }
    }
}
