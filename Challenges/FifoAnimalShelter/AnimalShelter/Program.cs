using AnimalShelter.Classes;
using System;

namespace AnimalShelter
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Declare placeholder variables - used later by various methods
            string menuSelection = "", newAnimalType = "", requestedAnimalType = "";
            Node returnedAnimal = null;

            // Instantiate queue Objects - provide initial Node values
            AnimalShelterQueue shelter = new AnimalShelterQueue();

            // Loop until the user enters the "4" key to exit the application
            do
            {
                // Reset animal types to an empty string, so that no previously entered values remain
                newAnimalType = "";
                requestedAnimalType = "";

                // Prompt user to select an option from the menu
                PrintMainMenu();
                menuSelection = Console.ReadLine();
                Console.Clear();

                switch (menuSelection)
                {
                    case "1": // Add an animal to the shelter
                        Console.WriteLine("What value you like the new Node to contain?");
                        newAnimalType = Console.ReadLine();

                        if (newAnimalType.ToLower() == "cat")
                        {
                            shelter.Enqueue(new Node(new Cat()));
                        }
                        else if (newAnimalType.ToLower() == "dog")
                        {
                            shelter.Enqueue(new Node(new Dog()));
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Sorry, you can only put dogs or cats into the shelter. Please try again.");
                        }

                        PromptToReturnToMainMenu();
                        break;
                    case "2": // Remove an animal from the shelter
                        Console.WriteLine("Which kind of animal would you like to take out of the shelter?");
                        requestedAnimalType = Console.ReadLine();
                        Console.Clear();

                        if (requestedAnimalType.ToLower() == "cat" || requestedAnimalType.ToLower() == "dog")
                        {
                            returnedAnimal = shelter.Dequeue(requestedAnimalType);

                            if (returnedAnimal != null)
                            {
                                Console.WriteLine(returnedAnimal.Name);
                            }
                            else
                            {
                                Console.WriteLine($"Sorry, we currently don't have any {requestedAnimalType}s in our shelter.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Sorry, we only allow dogs and cats in our shelter.");
                        }

                        PromptToReturnToMainMenu();
                        break;
                    case "3": // See which animals has been in the shelter the longest
                        returnedAnimal = shelter.Peek();

                        if (returnedAnimal != null)
                        {
                            Console.WriteLine(returnedAnimal.Name);
                        }
                        else
                        {
                            Console.WriteLine("Sorry, we don't have any animals in our shelter.");
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
                    "1) Add an animal to the shelter\n" +
                    "2) Remove an animal from the shelter\n" +
                    "3) See which animals has been in the shelter the longest\n" +
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
