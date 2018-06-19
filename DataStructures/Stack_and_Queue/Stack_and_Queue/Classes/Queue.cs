using System;
using System.Collections.Generic;
using System.Text;

namespace Stack_and_Queue.Classes
{
    public class Queue
    {
        public Node Front { get; set; }
        public Node Rear { get; set; }

        public Queue(Node node)
        {
            Front = node;
            Rear = node;
        }

        public void Enqueue(Node node)
        {
            Rear.Next = node;
            Rear = node;
        }

        public Node Dequeue()
        {
            if (Front != null)
            {
                Node temp = Front;
                Front = Front.Next;

                temp.Next = null;
                return temp;
            }

            return null;
        }

        public Node Peek()
        {
            return Front;
        }
    }
}
