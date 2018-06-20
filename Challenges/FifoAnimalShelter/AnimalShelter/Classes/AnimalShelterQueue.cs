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
        /// Constructor method for creating the Queue
        /// </summary>
        /// <param name="node"></param>
        public AnimalShelterQueue(Node node)
        {
            Front = node;
            Rear = node;
        }

        public AnimalShelterQueue()
        {

        }

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

        public Node Peek()
        {
            return Front;
        } 



    }
}
