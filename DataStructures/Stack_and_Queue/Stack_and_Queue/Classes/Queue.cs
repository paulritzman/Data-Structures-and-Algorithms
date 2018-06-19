using System;
using System.Collections.Generic;
using System.Text;

namespace Stack_and_Queue.Classes
{
    public class Queue
    {
        // Declares fields for the first Node in the Queue (Front), and last Node added to the Queue (Rear)
        public Node Front { get; set; }
        public Node Rear { get; set; }

        /// <summary>
        /// Constructor method for creating the Queue
        /// </summary>
        /// <param name="node"></param>
        public Queue(Node node)
        {
            Front = node;
            Rear = node;
        }

        /// <summary>
        /// Method which adds a Node to the rear of the Queue
        /// </summary>
        /// <param name="node">Node to add</param>
        public void Enqueue(Node node)
        {
            Rear.Next = node;
            Rear = node;
        }

        /// <summary>
        /// Method which removes a Node from the front of the Queue
        /// </summary>
        /// <returns>Node</returns>
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

        /// <summary>
        /// Method which grabs the Node at the front of the Queue without removing the Node
        /// </summary>
        /// <returns>Node</returns>
        public Node Peek()
        {
            return Front;
        }
    }
}
