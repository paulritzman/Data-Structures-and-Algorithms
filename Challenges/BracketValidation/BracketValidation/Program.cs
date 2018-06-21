using Stack_and_Queue.Classes;
using System;

namespace BracketValidation
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Declare placeholder variables - used later by various methods
            string menuSelection = "", userInput = "";
            bool bracketsAreEven = true;

            // Loop until the user enters the "3" key to exit the application
            do
            {
                // Prompt user to select an option from the menu
                PrintMainMenu();
                menuSelection = Console.ReadLine();
                Console.Clear();

                switch (menuSelection)
                {
                    case "1": // Check if string has balanced brackets
                        Console.WriteLine("Please enter a string to check if the brackets are even.\n");
                        userInput = Console.ReadLine();
                        Console.Clear();

                        // Check string and print results
                        bracketsAreEven = MultiBracketValidation(userInput);
                        Console.WriteLine(bracketsAreEven);

                        PromptToReturnToMainMenu();
                        break;
                    case "2": // View Rules and Examples
                        DisplayRules();

                        PromptToReturnToMainMenu();
                        break;
                    case "3": // Exits the Program
                        Environment.Exit(0);
                        break;
                    default: // Handles cases where user doesn't enter a valid menu option
                        Console.WriteLine("That did not match one of the menu options. Try again.\n");
                        break;
                }
            } while (menuSelection != "3");
        }

        /// <summary>
        /// Method which prints the main menu to the console window.
        /// </summary>
        public static void PrintMainMenu()
        {
            Console.WriteLine(
                    "Select an option from the menu below:\n" +
                    "1) Check if string has balanced brackets\n" +
                    "2) View Rules and Examples\n" +
                    "3) Exit Program");
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
        /// Method which prints the rules for entering brackets and shows example inputs/outputs.
        /// </summary>
        public static void DisplayRules()
        {
            Console.WriteLine(
                    "Valid opening brackets are: (, [, {\n" +
                    "Valid closing brackets are: ), ], }\n");

            Console.WriteLine(
                    "Examples that return \"True\":\n" +
                    "- {}\n" +
                    "- {}(){}\n" +
                    "- ()[[Extra Characters]]\n" +
                    "- (){}[[]]\n" +
                    "- {}{Extra[Characters](())}\n" +
                    "- No brackets\n");

            Console.WriteLine(
                    "Examples that return \"False\":\n" +
                    "- [({}]\n" +
                    "- [(])\n" +
                    "- ][\n" +
                    "- {\n" +
                    "- }");
        }

        /// <summary>
        /// Method used to check if the brackets in a string are balanced.
        /// Returns true if each opening bracket is followed by the corresponding closing bracket.
        /// </summary>
        /// <param name="input">String</param>
        /// <returns>Boolean</returns>
        public static bool MultiBracketValidation(string input)
        {
            Stack stack = new Stack();
            int count = 0;

            foreach (char c in input)
            {
                switch (c)
                {
                    case '(':
                    case '[':
                    case '{':
                        stack.Push(new Node(c.ToString()));
                        count++;
                        break;
                    case ')':
                        if (stack.Top == null || stack.Top.Value != "(")
                        {
                            return false;
                        }

                        stack.Pop();
                        count--;
                        break;
                    case ']':
                        if (stack.Top == null || stack.Top.Value != "[")
                        {
                            return false;
                        }

                        stack.Pop();
                        count--;
                        break;
                    case '}':
                        if (stack.Top == null || stack.Top.Value != "{")
                        {
                            return false;
                        }

                        stack.Pop();
                        count--;
                        break;
                }
            }

            return count == 0;
        }
    }
}
