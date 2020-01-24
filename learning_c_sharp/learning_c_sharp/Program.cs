using System;
using System.Text;

namespace learning_c_sharp
{
    class Program {
        static bool isRunning = true;


        static void Main (string[] args) {
            while(isRunning)
            {
                DisplayUserOptions();
                int userChoice = GetUserInput();
                ParseUserInput(userChoice);

                Console.WriteLine("\n\nPress (Enter) to confirm");
                Console.ReadLine();
                Console.Clear();
            }
        }


        static void DisplayUserOptions()
        {
            var displayText = new StringBuilder();
            displayText
                .AppendLine("Choose an option and press (Enter): ")
                .AppendLine("\t0. Quit")
                .AppendLine("\t1. Variables")
                .AppendLine("\t2. Arrays")
                .AppendLine("\t3. Loops")
                .AppendLine("\t4. Conditionals")
                .AppendLine("\t5. Object and Methods")
                .AppendLine("\t6. Dates")
                .AppendLine("\t7. Files");

            Console.WriteLine(displayText);
        }


        static int GetUserInput()
        {
            try
            {
                return int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                return -1;
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
                case (int)Options.Dates:
                    _ = new Dates();
                    break;
                case (int)Options.Files:
                    _ = new Files();
                    break;
                default:
                    Console.WriteLine("Invalid option...");
                    break;
            }
        }
    }
}