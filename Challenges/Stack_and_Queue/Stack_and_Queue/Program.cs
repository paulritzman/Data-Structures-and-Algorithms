using System;
using Stack_and_Queue.Classes;

namespace Stack_and_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            string menuSelection = "", newNode = "";
            Node returnedNode = null;

            Stack stack = new Stack(new Node("zzz"));
            Queue queue = new Queue(new Node("111"));

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
                            stack.Push(new Node(newNode));
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Sorry, you must input a value for the Node. Please try again.");
                        }

                        Console.Write("\nPress any key to return to main menu...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "2":
                        returnedNode = stack.Pop();
                        Console.WriteLine(returnedNode.Value);

                        Console.Write("\nPress any key to return to main menu...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "3":
                        returnedNode = stack.Peek();
                        Console.WriteLine(returnedNode.Value);

                        Console.Write("\nPress any key to return to main menu...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "4":
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

                        Console.Write("\nPress any key to return to main menu...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "5":
                        returnedNode = queue.Dequeue();
                        Console.WriteLine(returnedNode.Value);

                        Console.Write("\nPress any key to return to main menu...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "6":
                        returnedNode = queue.Peek();
                        Console.WriteLine(returnedNode.Value);

                        Console.Write("\nPress any key to return to main menu...");
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
                    "1) Add a Node to the Stack\n" +
                    "2) Remove a Node from the Stack\n" +
                    "3) Peek at the top of the Stack\n" +
                    "4) Add a Node to the Queue\n" +
                    "5) Remove a Node from the Queue\n" +
                    "6) Peek at the front of the Queue\n" +
                    "7) Exit Program");
        }
    }
}
