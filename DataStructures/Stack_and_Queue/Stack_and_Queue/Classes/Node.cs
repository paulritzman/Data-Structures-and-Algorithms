using System;
using System.Collections.Generic;
using System.Text;

namespace Stack_and_Queue.Classes
{
    class Node
    {
        public string Value { get; set; }
        public Node Next { get; set; }
        
        public Node(string value)
        {
            Value = value;
        }

    }
}
