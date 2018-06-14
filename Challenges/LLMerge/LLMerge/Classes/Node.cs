using System;
using System.Collections.Generic;
using System.Text;

namespace LLMerge.Classes
{
    class Node
    {
        // Node properties
        public string Value { get; set; }
        public Node Next { get; set; }

        // Node Constructor
        public Node(string value)
        {
            Value = value;
        }
    }
}
