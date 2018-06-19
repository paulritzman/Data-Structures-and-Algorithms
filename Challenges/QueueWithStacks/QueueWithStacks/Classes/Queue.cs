using System;
using System.Collections.Generic;
using System.Text;

namespace QueueWithStacks.Classes
{
    public class Queue
    {
        // Declares fields for the first Node in the Queue (Front), and last Node added to the Queue (Rear)
        public Node Front { get; set; }
        public Node Rear { get; set; }
        public Node TempNode { get; set; }

        // Instantiates 2 empty Stacks for use in mimicing Enqueue/Dequeue functionality for the Queue
        Stack stack1 = new Stack();
        Stack stack2 = new Stack();

        /// <summary>
        /// Constructor method for creating a Queue
        /// </summary>
        public Queue()
        {

        }

        /// <summary>
        /// Method which adds a Node to the rear of the Queue, using 2 Stacks to perform functionality.
        /// </summary>
        /// <param name="node">Node to add</param>
        public void Enqueue(Node inputNode)
        {
            while (stack2.Top != null)
            {
                stack1.Push(stack2.Pop());
            }

            stack1.Push(inputNode);

            Rear = stack1.Top;

            if (stack1.Top.Next == null) { Front = stack1.Top; }
        }

        /// <summary>
        /// Method which removes a Node from the front of the Queue, using 2 Stacks to perform functionality.
        /// </summary>
        /// <returns>Node</returns>
        public Node Dequeue()
        {
            while (stack1.Top != null)
            {
                stack2.Push(stack1.Pop());
            }

            TempNode = stack2.Pop();
            Front = stack2.Top;

            return TempNode;
        }

        /// <summary>
        /// Method which grabs the Node at the front of the Queue without removing the Node.
        /// </summary>
        /// <returns>Node</returns>
        public Node Peek()
        {
            if (Front != null) { return Front; }

            return null;
        }
    }
}
