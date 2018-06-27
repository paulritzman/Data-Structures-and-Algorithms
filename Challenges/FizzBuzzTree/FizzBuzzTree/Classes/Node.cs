using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzzTree.Classes
{
    public class Node
    {
        /// <summary>
        /// Declares Class fields - provides getters and setters
        /// </summary>
        public string Value { get; set; }
        public Node LeftChild { get; set; }
        public Node RightChild { get; set; }

        /// <summary>
        /// Constructor method for creating Nodes
        /// </summary>
        /// <param name="value">String</param>
        public Node(string value)
        {
            Value = value;
        }
    }
}
