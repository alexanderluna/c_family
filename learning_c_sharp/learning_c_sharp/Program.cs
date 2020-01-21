using System;

namespace learning_c_sharp
{
    class Program {
        static bool isRunning = true;


        static void Main (string[] args) {
            while(isRunning)
            {
                DisplayUserOptions();
                int userInput = GetUserInput();
                ParseUserInput(userInput);

                Console.WriteLine("\n\nPress (Enter) to confirm");
                Console.ReadLine();
                Console.Clear();
            }
        }


        static void DisplayUserOptions()
        {
            Console.WriteLine(
                "Choose an option and press (Enter): " +
                "\n\t1. Quit" +
                "\n\t2. Variables" +
                "\n\t3. Arrays" +
                "\n\t4. Loops" +
                "\n\t5. Conditionals" +
                "\n\t6. Object and Methods"
            );
        }


        static int GetUserInput()
        {
            try
            {
                return int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                return 0;
            }
        }


        static void ParseUserInput(int userInput)
        {
            switch (userInput)
            {
                case (int)Options.Quit:
                    isRunning = false;
                    break;
                case (int)Options.Variables:
                    _ = new Variables();
                    break;
                case (int)Options.Arrays:
                    _ = new Arrays();
                    break;
                case (int)Options.Loops:
                    _ = new Loops();
                    break;
                case (int)Options.Conditionals:
                    _ = new Conditionals();
                    break;
                case (int)Options.ObjectAndMethods:
                    _ = new ObjectsAndMethods();
                    ObjectsAndMethods.NoInstanceNeeded();
                    break;
                default:
                    Console.WriteLine("Invalid option...");
                    break;
            }
        }
    }
}