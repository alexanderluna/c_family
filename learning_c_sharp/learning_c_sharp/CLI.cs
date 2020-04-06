using System;
using System.Text;

namespace learning_c_sharp
{
    public static class CLI
    {
        public static void DisplayUserOptions()
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
                .AppendFormat("\t{0}. {1}\n", (int)Options.GetterSetter, Options.GetterSetter.ToString())
                .AppendFormat("\t{0}. {1}\n", (int)Options.Inheritance, Options.Inheritance.ToString());

            Console.WriteLine(displayText);
        }


        public static int GetUserInput()
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

        public static void PromptForInput()
        {
            Console.WriteLine("\n\nPress (Enter)");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
