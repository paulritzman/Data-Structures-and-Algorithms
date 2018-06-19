using System;
using QueueWithStacks.Classes;

namespace QueueWithStacks
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Declare placeholder variables - used later by various methods
            string menuSelection = "", newNode = "";
            Node returnedNode = null;

            // Instantiate queue Object
            Queue queue = new Queue();

            // Loop until the user enters the "4" key to exit the application
            do
            {
                // Reset newNode to an empty string, so that no previously entered values remain
                newNode = "";

                // Prompt user to select an option from the menu
                PrintMainMenu();
                menuSelection = Console.ReadLine();
                Console.Clear();

                switch (menuSelection)
                {
                    case "1": // Adds a Node to the Queue
                        Console.WriteLine("What value you like the new Node to contain?");
                        newNode = Console.ReadLine();

                        if (newNode != "")
                        {
                            queue.Enqueue(new Node(newNode));
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Sorry, you must input a value for the Node. Please try again.");
                        }

                        PromptToReturnToMainMenu();
                        break;
                    case "2": // Removes a Node from the Queue
                        returnedNode = queue.Dequeue();
                        if (returnedNode != null)
                        {
                            Console.WriteLine(returnedNode.Value);
                        }
                        else
                        {
                            Console.WriteLine("There are currently no Nodes in the Queue.");
                        }

                        PromptToReturnToMainMenu();
                        break;
                    case "3": // Peeks at the front of the Queue
                        returnedNode = queue.Peek();
                        if (returnedNode != null)
                        {
                            Console.WriteLine(returnedNode.Value);
                        }
                        else
                        {
                            Console.WriteLine("There are currently no Nodes in the Queue.");
                        }
                        
                        PromptToReturnToMainMenu();
                        break;
                    case "4": // Exits the Program
                        Environment.Exit(0);
                        break;
                    default: // Handles cases where user doesn't enter a valid menu option
                        Console.WriteLine("That did not match one of the menu options. Try again.\n");
                        break;
                }

            } while (menuSelection != "4");
        }

        /// <summary>
        /// Method which prints the main menu to the console window.
        /// </summary>
        public static void PrintMainMenu()
        {
            Console.WriteLine(
                    "Select an option from the menu below:\n" +
                    "1) Add a Node to the Queue\n" +
                    "2) Remove a Node from the Queue\n" +
                    "3) Peek at the front of the Queue\n" +
                    "4) Exit Program");
        }

        /// <summary>
        /// Method which prompts the user to press any key to return to the main menu. Clears the console window.
        /// </summary>
        public static void PromptToReturnToMainMenu()
        {
            Console.Write("\nPress any key to return to main menu...");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
