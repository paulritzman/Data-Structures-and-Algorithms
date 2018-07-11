using System;
using System.Collections.Generic;
using System.Text;

namespace Graphs.Classes
{
    public class Node
    {
        public string Value { get; set; }
        public bool Visited { get; set; }
        public List<Node> Neighbors { get; set; }

        public Node(string value)
        {
            Neighbors = new List<Node>();
            Value = value;
        }
    }
}
