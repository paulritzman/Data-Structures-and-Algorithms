using System;
using System.Collections.Generic;
using System.Text;

namespace Stack_and_Queue.Classes
{
    public class Stack
    {
        public Node Top { get; set; }

        public Stack(Node node)
        {
            Top = node;
        }

        public void Push(Node node)
        {
            node.Next = Top;
            Top = node;
        }

        public Node Pop()
        {
            if (Top != null)
            {
                Node Temp = Top;
                Top = Top.Next;

                Temp.Next = null;
                return Temp;
            }

            return null;
        }

        public Node Peek()
        {
            return Top;
        }
    }
}
