using System;
using LLKthElementFromEnd.Classes;

namespace LLKthElementFromEnd
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Run the program to find the Node "k" distance from the end of the Linked List
            RunProgram();
        }
        
        /// <summary>
        /// Method called on application start - used to run through main program logic.
        /// </summary>
        public static void RunProgram()
        {
            LinkedList ll = new LinkedList(new Node(""));
            ll = ll.CreateLinkedList();

            string menuSelection = "", kInput = "";
            int kDistance = -1;
            Node foundNode = null;

            do
            {
                PrintMainMenu();
                menuSelection = Console.ReadLine();
                Console.Clear();

                switch (menuSelection)
                {
                    case "1":
                        ll.PrintLinkedList();

                        ReturnToMainMenuPrompt();
                        break;
                    case "2":
                        kDistance = -1;
                        while (kDistance == -1)
                        {
                            Console.WriteLine(
                                    "How many spaces from the end of the Linked List " +
                                    "would you like to search for a Node?\n" +
                                    "(0 returns the last Node in the Linked List)\n");
                            kInput = Console.ReadLine();
                            Console.Clear();
                            kDistance = VerifyKDistance(kInput);
                        }

                        try
                        {
                            foundNode = ll.KthElement(kDistance);
                            Console.WriteLine(
                                    $"The Element {kDistance} Nodes from the end " +
                                    $"of the Linked List is: {foundNode.Value}");
                        }
                        catch
                        {
                            Console.Clear();
                            Console.WriteLine(
                                    "Sorry, no Nodes exist at that " +
                                    "distance from the end of the Linked List.");
                        }
                        ReturnToMainMenuPrompt();
                        break;
                    case "3":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Sorry, that didn't match any of the menu options.\n");
                        break;
                }

            } while (menuSelection != "3");
        }

        /// <summary>
        /// Method which prints the main menu options.
        /// </summary>
        private static void PrintMainMenu()
        {
            Console.WriteLine(
                    "Please choose an option from the menu below:\n" +
                    "1) View the values of all Nodes in the Linked List\n" +
                    "2) Find the value of a Node \"k\" distance from the end of the Linked List\n" +
                    "3) Close program\n");
        }

        /// <summary>
        /// Method which prompts users to press any key to return to the main menu.
        /// </summary>
        private static void ReturnToMainMenuPrompt()
        {
            Console.Write("\nPress any key to return to main menu...");
            Console.ReadKey();
            Console.Clear();
        }

        /// <summary>
        /// Method which checks that kInput is a positive integer value.
        /// </summary>
        /// <param name="kInput">distance from end of Linked List</param>
        /// <returns>Integer: parsed integer from input string</returns>
        public static int VerifyKDistance(string kInput)
        {
            try
            {
                int kDistance = int.Parse(kInput);

                if (kDistance < 0)
                {
                    throw new IndexOutOfRangeException();
                }

                return kDistance;
            }
            catch
            {
                Console.WriteLine("Please enter a non-negative integer.\n");
                return -1;
            }
        }
    }
}
