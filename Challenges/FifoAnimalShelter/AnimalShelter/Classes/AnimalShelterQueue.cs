using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalShelter.Classes
{
    public class AnimalShelterQueue
    {
        // Declares fields for the first Node in the Queue (Front), and last Node added to the Queue (Rear)
        public Node Front { get; set; }
        public Node Rear { get; set; }
        public Node Temp { get; set; }
        public Node Temp2 { get; set; }

        /// <summary>
        /// Constructor method for creating the an Empty Animal Shelter Queue
        /// </summary>
        /// <param name="node"></param>
        public AnimalShelterQueue()
        {

        }

        /// <summary>
        /// Method which adds an Animal Node to the rear of the Animal Shelter Queue
        /// </summary>
        /// <param name="node">Node to add</param>
        public void Enqueue(Node node)
        {
            if (Front == null)
            {
                Front = node;
                Rear = node;
            }
            else
            {
                Rear.Next = node;
                Rear = node;
            }
        }

        /// <summary>
        /// Method which removes an Animal Node from the front of the Animal Shelter Queue
        /// </summary>
        /// <returns>Node containing Animal Object</returns>
        public Node Dequeue(string animalType)
        {
            Temp = Front;

            // return null if no animals are in shelter
            if (Temp == null)
            {
                return Temp;
            }

            // check if animalType is first animal in shelter
            if (animalType == Temp.Name)
            {
                if (Temp.Next != null)
                {
                    Front = Front.Next;
                    Temp.Next = null;
                }
                else
                {
                    Front = null;
                }
                return Temp;
            }

            // search for animal in shelter, return animal if found
            while (Temp.Next != null)
            {
                if (animalType == Temp.Next.Name)
                {
                    Temp2 = Temp.Next;
                    Temp.Next = Temp2.Next; // "leap frog" over Temp2, connecting to the next Node
                    Temp2.Next = null; // disconnect Temp2 from the AnimalShelterQueue
                    return Temp2;
                }

                Temp = Temp.Next;
            }

            // return animal in shelter longest if unable to find input animalType in shelter
            if (Temp.Name != animalType)
            {
                Temp = Front;
                Front = Front.Next;
                Temp.Next = null;
            }
            
            return Temp;
        }

        /// <summary>
        /// Method which grabs the Node at the front of the Animal Shelter Queue without removing the Node
        /// </summary>
        /// <returns>Node</returns>
        public Node Peek()
        {
            return Front;
        }
    }
}
