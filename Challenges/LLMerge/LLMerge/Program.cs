using System;
using LLMerge.Classes;

namespace LLMerge
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Start the application
            RunProgram();
        }
        
        public static void RunProgram()
        {
            // Declare and instantiate Linked Lists
            LinkedList LL1 = new LinkedList(new Node(""));
            LL1 = LL1.CreateLinkedList();

            LinkedList LL2 = new LinkedList(new Node(""));
            LL2 = LL2.CreateLinkedList();

            string menuSelection = "";

            do
            {
                PrintMainMenu();
                menuSelection = Console.ReadLine();
                Console.Clear();

                switch (menuSelection)
                {
                    case "1": // Prints the two Linked Lists to the screen
                        LL1.PrintLinkedList();
                        Console.WriteLine();
                        LL2.PrintLinkedList();

                        ReturnToMainMenuPrompt();
                        break;
                    case "2": // Merges Linked Lists together and prints the merged Linked List to the screen
                        LL1.MergeLists(LL1, LL2);
                        LL1.PrintLinkedList();
                        ReturnToMainMenuPrompt();
                        break;
                    case "3": // Exits the applictation
                        Environment.Exit(0);
                        break;
                    default: // Handle user input that doesn't match other cases
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
                    "2) Merge the Linked Lists\n" +
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
    }
}
