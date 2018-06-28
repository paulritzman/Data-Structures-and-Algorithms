using System;
using Trees.Classes;

namespace FindMaxBinaryTree
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Declare placeholder variables - used later by various methods
            string menuSelection = "", newNodeInput = "";

            // Instantiate a Binary Tree and populate the Tree with an initial seed of Nodes
            // Set the current mamimum value in the tree to the Root Node of the Tree
            BinaryTree binTree = PopulateTree();
            int maximumValInTree = binTree.Root.Value;
            
            // Loop until the user enters the "7" key to exit the application
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

                        if (int.TryParse(newNodeInput, out int binTree_Add))
                        {
                            binTree.Add(binTree.Root, new Node(binTree_Add));
                            Console.WriteLine("Success!");
                        }
                        else
                        {
                            Console.WriteLine("Sorry, unable to add that value to the Binary Tree.");
                        }

                        PromptToReturnToMainMenu();
                        break;
                    case "2": // Finds the maximum value of a Node within the Binary Tree
                        maximumValInTree = FindMax(binTree.Root, maximumValInTree);
                        Console.WriteLine(maximumValInTree);

                        PromptToReturnToMainMenu();
                        break;
                    case "3": // Prints the values in the Binary Tree in "Preorder" sequence
                        binTree.PreOrder(binTree.Root);
                        Console.WriteLine();

                        PromptToReturnToMainMenu();
                        break;
                    case "4": // Prints the values in the Binary Tree in "Postorder" sequence
                        binTree.PostOrder(binTree.Root);
                        Console.WriteLine();

                        PromptToReturnToMainMenu();
                        break;
                    case "5": // Prints the values in the Binary Tree in "Inorder" sequence
                        binTree.InOrder(binTree.Root);
                        Console.WriteLine();

                        PromptToReturnToMainMenu();
                        break;
                    case "6": // Prints the values in the Binary Tree in "Breadth First" sequence
                        binTree.BreadthFirst(binTree.Root);
                        Console.WriteLine();

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
                    "1) Add a value to the Binary Tree\n" +
                    "2) Find the maximum value in Binary Tree\n" +
                    "3) Print the values in the Binary Tree in \"Preorder\" sequence\n" +
                    "4) Print the values in the Binary Tree in \"Postorder\" sequence\n" +
                    "5) Print the values in the Binary Tree in \"Inorder\" sequence\n" +
                    "6) Print the values in the Binary Tree in \"Breadth First\" sequence\n" +
                    "7) Exit Program\n");
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
        /// Method which Finds the maximum value for a Node within a Binary Tree
        /// </summary>
        /// <param name="root">Root Node of the Binary Tree</param>
        /// <param name="maxValue">Integer to store and return the maximum Node value</param>
        /// <returns></returns>
        public static int FindMax(Node root, int maxValue)
        {
            if (root.Value > maxValue)
            {
                maxValue = root.Value;
            }

            if (root.LeftChild != null)
            {
                maxValue = FindMax(root.LeftChild, maxValue);
            }

            if (root.RightChild != null)
            {
                maxValue = FindMax(root.RightChild, maxValue);
            }

            return maxValue;
        }

        /// <summary>
        /// Helper method which instantiates a Binary Tree and adds Nodes onto the Binary Tree
        /// </summary>
        /// <returns>Binary Tree seeded with an initial set of Nodes</returns>
        public static BinaryTree PopulateTree()
        {
            BinaryTree binTree = new BinaryTree(new Node(10));
            binTree.Add(binTree.Root, new Node(5));
            binTree.Add(binTree.Root, new Node(1));
            binTree.Add(binTree.Root, new Node(-5));
            binTree.Add(binTree.Root, new Node(20));
            binTree.Add(binTree.Root, new Node(50));
            binTree.Add(binTree.Root, new Node(55));
            binTree.Add(binTree.Root, new Node(45));
            binTree.Add(binTree.Root, new Node(63));
            binTree.Add(binTree.Root, new Node(27));

            return binTree;
        }
    }
}
