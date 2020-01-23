using System;

namespace learning_c_sharp
{
    public class Variables
    {
        private readonly char initial = 'A';
        private readonly string lastName = "Luna";
        private readonly int year = 2020;
        private readonly bool summer = true;


        public Variables()
        {
            Console.WriteLine("===> Setting up Variables");
            PrintVariables();
        }


        private void PrintVariables()
        {
            Console.WriteLine("Character: {0}", initial);
            Console.WriteLine("String: {0}", lastName);
            Console.WriteLine("Int: {0}", year);
            Console.WriteLine("Boolean: {0}", summer);
        }
    }
}
