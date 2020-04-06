using System;

namespace learning_c_sharp
{
    class Program {
        private static bool isRunning = true;


        static void Main (string[] args) {
            while(isRunning)
            {
                CLI.DisplayUserOptions();
                int userChoice = CLI.GetUserInput();
                ParseUserInput(userChoice);
                CLI.PromptForInput();
            }
        }


        private static void ParseUserInput(int userInput)
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
                case (int)Options.GetterSetter:
                    var GetterSetter = new GetterSetter(new DateTime(1991, 5, 4));
                    _ = GetterSetter.Age;
                    break;
                case (int)Options.Inheritance:
                    var Inheritance = new Cat("brown", 23.5, 4);
                    break;
                default:
                    Console.WriteLine("Invalid option...");
                    break;
            }
        }
    }
}