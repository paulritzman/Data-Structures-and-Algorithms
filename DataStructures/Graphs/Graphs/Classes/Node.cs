using System;
using System.Collections.Generic;
using System.Text;

namespace Graphs.Classes
{
    public class Node
    {
        public string Value { get; set; }
        public bool Visited { get; set; }
        public List<Edge> Edges { get; set; }

        public Node(string value)
        {
            Edges = new List<Edge>();
            Value = value;
        }
    }
}
