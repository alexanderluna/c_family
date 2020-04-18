using System;
using System.Text;

namespace learning_c_sharp
{
    public static class CLI
    {
        public static void DisplayUserOptions()
        {
            foreach (int index in Enum.GetValues(typeof(Options)))
            {
                Console.WriteLine(
                    "\t{0}.\t {1}",
                    index,
                    Enum.GetName(typeof(Options), index)
                );
            }
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
