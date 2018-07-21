using System;
using System.Collections.Generic;
using System.Text;

namespace Graphs.Classes
{
    public class Edge
    {
        public int Weight { get; set; }
        public Node Target { get; set; }

        public Edge(Node target)
        {
            Target = target;
        }

        public Edge(Node target, int weight)
        {
            Target = target;
            Weight = weight;
        }
    }
}
