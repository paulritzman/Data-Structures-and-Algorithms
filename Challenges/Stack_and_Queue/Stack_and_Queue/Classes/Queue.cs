using System;
using System.Collections.Generic;
using System.Text;

namespace Stack_and_Queue.Classes
{
    class Queue
    {
        public Node Front { get; set; }
        public Node Rear { get; set; }

        public void Enqueue(Node node)
        {
            if (Front == null)
            {
                Front = node;
            }

            if (Rear != null)
            {
                Rear.Next = node;
            }

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
