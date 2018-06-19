using System;
using System.Collections.Generic;
using System.Text;

namespace QueueWithStacks.Classes
{
    public class Node
    {   // Declares fields for the "Next" Node in the Stack or Queue, and the "Value" of each Node
        public string Value { get; set; }
        public Node Next { get; set; }

        /// <summary>
        /// Constructor method for creating Nodes
        /// </summary>
        /// <param name="value">String Value to store in Node</param>
        public Node(string value)
        {
            Value = value;
        }
    }
}
