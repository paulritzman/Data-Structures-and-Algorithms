using System;
using LinkedLists.Classes;

namespace LinkedLists
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string menuSelection = "", newNode = "", existingNode = "";

            LinkedList ll = new LinkedList(new Node("zzz"));

            do
            {
                newNode = "";

                PrintMainMenu();
                menuSelection = Console.ReadLine();
                Console.Clear();

                switch (menuSelection)
                {
                    case "1":
                        Console.WriteLine("What value you like the new Node to contain?");
                        newNode = Console.ReadLine();

                        if (newNode != "")
                        {
                            ll.AddNode(new Node(newNode));
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Sorry, you must input a value for the Node. Please try again.");
                        }

                        Console.WriteLine("\nPress any key to return to main menu...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "2":
                        Console.WriteLine("What value you like the new Node to contain?");
                        newNode = Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine("What is the value of the existing Node to insert the new Node before?");
                        existingNode = Console.ReadLine();

                        if (newNode != "" && existingNode != "")
                        {
                            ll.AddBefore(new Node(newNode), new Node(existingNode));
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Sorry, you must input a value for both Nodes. Please try again.");
                        }

                        Console.WriteLine("\nPress any key to return to main menu...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "3":
                        Console.WriteLine("What value you like the new Node to contain?");
                        newNode = Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine("What is the value of the existing Node to insert the new Node after?");
                        existingNode = Console.ReadLine();

                        if (newNode != "" && existingNode != "")
                        {
                            ll.AddAfter(new Node(newNode), new Node(existingNode));
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Sorry, you must input a value for both Nodes. Please try again.");
                        }

                        Console.WriteLine("\nPress any key to return to main menu...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "4":
                        Console.WriteLine("What value you like the new Node to contain?");
                        newNode = Console.ReadLine();

                        if (newNode != "")
                        {
                            ll.AddLast(new Node(newNode));
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Sorry, you must input a value for the Node. Please try again.");
                        }

                        Console.WriteLine("\nPress any key to return to main menu...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "5":
                        Console.WriteLine("What is the value of the Node you would like to find?");
                        existingNode = Console.ReadLine();

                        if (existingNode != "")
                        {
                            Node checkNode = ll.Find(existingNode);
                            if (checkNode != null)
                            {
                                Console.WriteLine("\nFound!");
                            }
                            else
                            {
                                Console.WriteLine("\nThat Node doesn't exist.");
                            }
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Sorry, you must input a value for the Node. Please try again.");
                        }

                        Console.WriteLine("\nPress any key to return to main menu...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "6":
                        ll.PrintNodes();

                        Console.WriteLine("\nPress any key to return to main menu...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "7":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("That did not match one of the menu options. Try again.\n");
                        break;
                }

            } while (menuSelection != "7");
        }

        public static void PrintMainMenu()
        {
            Console.WriteLine(
                    "Select an option from the menu below:\n" +
                    "1) Add a Node to the beginning of the Linked List\n" +
                    "2) Add a Node before another Node\n" +
                    "3) Add a Node after another Node\n" +
                    "4) Add a Node to the end of the Linked List\n" +
                    "5) Find a Node\n" +
                    "6) Print all Nodes\n" +
                    "7) Exit Program");
        }
    }
}
