using System;
using System.Collections.Generic;
using System.Text;

namespace Trees.Classes
{
    public class Node
    {
        /// <summary>
        /// Declares Class fields - provides getters and setters
        /// </summary>
        public int Value { get; set; }
        public Node LeftChild { get; set; }
        public Node RightChild { get; set; }

        /// <summary>
        /// Constructor method for creating Nodes
        /// </summary>
        /// <param name="value">Integer</param>
        public Node(int value)
        {
            Value = value;
        }
    }
}
