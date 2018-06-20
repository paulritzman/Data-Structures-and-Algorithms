using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalShelter.Classes
{
    public class Node
    {
        // Declares fields for the "Next" Node in the Stack or Queue, and the "Value" of each Node
        public Cat Cat { get; set; }
        public Dog Dog { get; set; }
        public string Name { get; }
        public Node Next { get; set; }

        /// <summary>
        /// Constructor method for creating Nodes
        /// </summary>
        /// <param name="value">String Value to store in Node</param>
        public Node(Cat cat)
        {
            Cat = cat;
            Name = "cat";
        }

        public Node (Dog dog)
        {
            Dog = dog;
            Name = "dog";
        }
    }
}
