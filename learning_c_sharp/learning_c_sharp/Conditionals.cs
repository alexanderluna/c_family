using System;
namespace learning_c_sharp
{
    public class Conditionals
    {


        public Conditionals()
        {
            Console.WriteLine("===> Conditions getting configured");
        }


        public void IfElseStatement(string season)
        {
            Console.WriteLine("Is it Summer ?");
            if (season == "winter")
            {
                Console.WriteLine("No, it's winter");
            } else
            {
                Console.WriteLine("Yes, it's summer");
            }
        }
    }
}
