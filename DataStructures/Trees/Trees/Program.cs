using System;
using Trees.Classes;

namespace Trees
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Declare placeholder variables - used later by various methods
            string menuSelection = "", newNodeInput = "", nodeSearchValue = "";
            Node returnedNode = null;

            // Instantiate BinaryTree and BinarySearchTree objects, add initial values
            BinaryTree binTree = new BinaryTree(new Node(25));
            binTree.Add(binTree.Root, new Node(10));
            binTree.Add(binTree.Root, new Node(5));
            binTree.Add(binTree.Root, new Node(7));
            binTree.Add(binTree.Root, new Node(1));
            binTree.Add(binTree.Root, new Node(40));
            binTree.Add(binTree.Root, new Node(50));
            binTree.Add(binTree.Root, new Node(30));

            BinarySearchTree binSearchTree = new BinarySearchTree(new Node(25));
            binSearchTree.Add(binSearchTree.Root, new Node(10));
            binSearchTree.Add(binSearchTree.Root, new Node(5));
            binSearchTree.Add(binSearchTree.Root, new Node(7));
            binSearchTree.Add(binSearchTree.Root, new Node(1));
            binSearchTree.Add(binSearchTree.Root, new Node(40));
            binSearchTree.Add(binSearchTree.Root, new Node(50));
            binSearchTree.Add(binSearchTree.Root, new Node(30));

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
                    case "2": // Adds a Node to the Binary Search Tree
                        Console.WriteLine("What value you like add to the Binary Search Tree?");
                        newNodeInput = Console.ReadLine();
                        Console.Clear();

                        if (int.TryParse(newNodeInput, out int binSearchTree_Add))
                        {
                            binTree.Add(binTree.Root, new Node(binSearchTree_Add));
                            Console.WriteLine("Success!");
                        }
                        else
                        {
                            Console.WriteLine("Sorry, unable to add that value to the Binary Search Tree.");
                        }

                        PromptToReturnToMainMenu();
                        break;
                    case "3": // Searches for a value in the Binary Tree
                        Console.WriteLine("What value you like search for in the Binary Tree?");
                        nodeSearchValue = Console.ReadLine();
                        Console.Clear();

                        if (int.TryParse(nodeSearchValue, out int binTree_Search))
                        {
                            Node foundBinTreeNode = binTree.Search(binTree.Root, binTree_Search);

                            if (foundBinTreeNode != null)
                            {
                                Console.WriteLine("Found!");
                            }
                            else
                            {
                                Console.WriteLine("That value does not exist within the Binary Tree");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Sorry, please input an integer to search for.");
                        }

                        PromptToReturnToMainMenu();
                        break;
                    case "4": // Searches for a value in the Binary Search Tree
                        Console.WriteLine("What value you like search for in the Binary Search Tree?");
                        nodeSearchValue = Console.ReadLine();
                        Console.Clear();

                        if (int.TryParse(nodeSearchValue, out int binSearchTree_Search))
                        {
                            Node foundBinTreeNode = binTree.Search(binTree.Root, binSearchTree_Search);

                            if (foundBinTreeNode != null)
                            {
                                Console.WriteLine("Found!");
                            }
                            else
                            {
                                Console.WriteLine("That value does not exist within the Binary Search Tree");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Sorry, please input an integer to search for.");
                        }

                        PromptToReturnToMainMenu();
                        break;
                    case "5": // Prints the values in the Binary Tree in "Preorder" sequence
                        binTree.PreOrder(binTree.Root);

                        PromptToReturnToMainMenu();
                        break;
                    case "6": // Prints the values in the Binary Tree in "Postorder" sequence
                        binTree.PostOrder(binTree.Root);

                        PromptToReturnToMainMenu();
                        break;
                    case "7": // Prints the values in the Binary Tree in "Inorder" sequence
                        binTree.InOrder(binTree.Root);

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
                    "2) Add a value to the Binary Search Tree\n" +
                    "3) Search for a value in the Binary Tree\n" +
                    "4) Search for a value in the Binary Search Tree\n" +
                    "5) Print the values in the Binary Tree in \"Preorder\" sequence\n" +
                    "6) Print the values in the Binary Tree in \"Postorder\" sequence\n" +
                    "7) Print the values in the Binary Tree in \"Inorder\" sequence\n" +
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



    }
}
