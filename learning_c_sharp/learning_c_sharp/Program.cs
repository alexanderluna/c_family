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

                Console.WriteLine("\n\nPress (Enter)");
                Console.ReadLine();
                Console.Clear();
            }
        }


        static void DisplayUserOptions()
        {
            StringBuilder displayText = new StringBuilder();
            displayText
                .AppendLine("Choose an option and press (Enter): ")
                .AppendFormat("\t{0}. {1}\n", (int)Options.Quit, Options.Quit.ToString())
                .AppendFormat("\t{0}. {1}\n", (int)Options.Variables, Options.Variables.ToString())
                .AppendFormat("\t{0}. {1}\n", (int)Options.Arrays, Options.Arrays.ToString())
                .AppendFormat("\t{0}. {1}\n", (int)Options.Loops, Options.Conditionals.ToString())
                .AppendFormat("\t{0}. {1}\n", (int)Options.Conditionals, Options.Conditionals.ToString())
                .AppendFormat("\t{0}. {1}\n", (int)Options.ObjectAndMethods, Options.ObjectAndMethods.ToString())
                .AppendFormat("\t{0}. {1}\n", (int)Options.Dates, Options.Dates.ToString())
                .AppendFormat("\t{0}. {1}\n", (int)Options.Files, Options.Files.ToString())
                .AppendFormat("\t{0}. {1}\n", (int)Options.GetterSetter, Options.GetterSetter.ToString());

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
                case (int)Options.GetterSetter:
                    var GetterSetter = new GetterSetter(new DateTime(1991, 5, 4));
                    _ = GetterSetter.Age;
                    break;
                default:
                    Console.WriteLine("Invalid option...");
                    break;
            }
        }
    }
}