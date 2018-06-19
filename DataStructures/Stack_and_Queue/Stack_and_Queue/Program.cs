using System;
using Stack_and_Queue.Classes;

namespace Stack_and_Queue
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Declare placeholder variables - used later by various methods
            string menuSelection = "", newNode = "";
            Node returnedNode = null;

            // Instantiate stack and queue Objects - provide initial Node values
            Stack stack = new Stack(new Node("zzz"));
            Queue queue = new Queue(new Node("111"));

            // Loop until the user enters the "7" key to exit the application
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
                    case "1": // Adds a Node to the Stack
                        Console.WriteLine("What value you like the new Node to contain?");
                        newNode = Console.ReadLine();

                        if (newNode != "")
                        {
                            stack.Push(new Node(newNode));
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Sorry, you must input a value for the Node. Please try again.");
                        }

                        PromptToReturnToMainMenu();
                        break;
                    case "2": // Removes a Node from the Stack
                        returnedNode = stack.Pop();
                        Console.WriteLine(returnedNode.Value);

                        PromptToReturnToMainMenu();
                        break;
                    case "3": // Peek at the top of the Stack
                        returnedNode = stack.Peek();
                        Console.WriteLine(returnedNode.Value);

                        PromptToReturnToMainMenu();
                        break;
                    case "4": // Adds a Node to the Queue
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
                    case "5": // Remove a Node from the Queue
                        returnedNode = queue.Dequeue();
                        Console.WriteLine(returnedNode.Value);

                        PromptToReturnToMainMenu();
                        break;
                    case "6": // Peeks at the front of the Queue
                        returnedNode = queue.Peek();
                        Console.WriteLine(returnedNode.Value);

                        PromptToReturnToMainMenu();
                        break;
                    case "7": // Exits the Program
                        Environment.Exit(0);
                        break;
                    default: // Handles cases where user doesn't enter a valid menu option
                        Console.WriteLine("That did not match one of the menu options. Try again.\n");
                        break;
                }

            } while (menuSelection != "7");
        }

        /// <summary>
        /// Method which prints the main menu to the console window.
        /// </summary>
        public static void PrintMainMenu()
        {
            Console.WriteLine(
                    "Select an option from the menu below:\n" +
                    "1) Add a Node to the Stack\n" +
                    "2) Remove a Node from the Stack\n" +
                    "3) Peek at the top of the Stack\n" +
                    "4) Add a Node to the Queue\n" +
                    "5) Remove a Node from the Queue\n" +
                    "6) Peek at the front of the Queue\n" +
                    "7) Exit Program");
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
