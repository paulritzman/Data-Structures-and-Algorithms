using FizzBuzzTree.Classes;
using System;

namespace FizzBuzzTree
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Declare placeholder variables - used later by various methods
            string menuSelection = "", newNodeInput = "";

            // Instantiate BinaryTree object, add initial values
            BinaryTree binTree = ResetBinaryTree();

            // Loop until the user enters the "8" key to exit the application
            do
            {
                // Prompt user to select an option from the menu
                PrintMainMenu();
                menuSelection = Console.ReadLine();
                Console.Clear();

                switch (menuSelection)
                {
                    case "1": // Adds a Node to the Binary Tree
                        Console.WriteLine("What value you like add to the Binary Tree?");
                        newNodeInput = Console.ReadLine();
                        Console.Clear();

                        string[] nodeInputArr = newNodeInput.Split(" ");

                        foreach (string n in nodeInputArr)
                        {
                            binTree.Add(binTree.Root, new Node(n));
                        }

                        Console.WriteLine("Success!");

                        PromptToReturnToMainMenu();
                        break;
                    case "2": // Converts Node Values to "FizzBuzz" values
                        Console.Write("Before: ");
                        binTree.PreOrder(binTree.Root);
                        Console.WriteLine();

                        binTree.ConvertToFizzBuzz(binTree.Root);

                        Console.Write("After: ");
                        binTree.PreOrder(binTree.Root);
                        Console.WriteLine();

                        PromptToReturnToMainMenu();
                        break;
                    case "3": // Resets Binary Tree to original Node Values
                        binTree = ResetBinaryTree();
                        Console.WriteLine("Your Binary Tree has been reset.");

                        PromptToReturnToMainMenu();
                        break;
                    case "4": // Prints the values in the Binary Tree in "Preorder" sequence
                        binTree.PreOrder(binTree.Root);

                        PromptToReturnToMainMenu();
                        break;
                    case "5": // Prints the values in the Binary Tree in "Postorder" sequence
                        binTree.PostOrder(binTree.Root);

                        PromptToReturnToMainMenu();
                        break;
                    case "6": // Prints the values in the Binary Tree in "Inorder" sequence
                        binTree.InOrder(binTree.Root);

                        PromptToReturnToMainMenu();
                        break;
                    case "7": // Prints the values in the Binary Tree in "Breadth First" sequence
                        binTree.BreadthFirst(binTree.Root);

                        PromptToReturnToMainMenu();
                        break;
                    case "8": // Exits the Program
                        Environment.Exit(0);
                        break;
                    default: // Handles cases where user doesn't enter a valid menu option
                        Console.WriteLine("That did not match one of the menu options. Try again.\n");
                        break;
                }
            } while (menuSelection != "8");            
        }

        /// <summary>
        /// Method which prints the main menu to the console window.
        /// </summary>
        public static void PrintMainMenu()
        {
            Console.WriteLine(
                    "Select an option from the menu below:\n" +
                    "1) Add a value to the Binary Tree\n" +
                    "2) Convert Node Values to \"FizzBuzz\" values\n" +
                    "3) Reset Binary Tree to original Node Values\n" +
                    "4) Print the values in the Binary Tree in \"Preorder\" sequence\n" +
                    "5) Print the values in the Binary Tree in \"Postorder\" sequence\n" +
                    "6) Print the values in the Binary Tree in \"Inorder\" sequence\n" +
                    "7) Print the values in the Binary Tree in \"Breadth First\" sequence\n" +
                    "8) Exit Program\n");
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

        /// <summary>
        /// Method which generates a Binary Tree with initial string Values
        /// </summary>
        /// <returns>Binary Tree</returns>
        public static BinaryTree ResetBinaryTree()
        {
            BinaryTree binTree = new BinaryTree(new Node("10"));
            binTree.Add(binTree.Root, new Node("5"));
            binTree.Add(binTree.Root, new Node("1"));
            binTree.Add(binTree.Root, new Node("7"));
            binTree.Add(binTree.Root, new Node("was"));
            binTree.Add(binTree.Root, new Node("18"));
            binTree.Add(binTree.Root, new Node("15"));
            binTree.Add(binTree.Root, new Node("30"));
            binTree.Add(binTree.Root, new Node("Paul"));
            binTree.Add(binTree.Root, new Node("here"));

            return binTree;
        }
    }
}
