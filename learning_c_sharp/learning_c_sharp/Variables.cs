using System;
namespace learning_c_sharp
{
    public class Variables
    {
        private char initial;
        private string lastName;
        private int year;
        private Boolean summer;

        public Variables()
        {
            initial = 'A';
            lastName = "Luna";
            year = 2019;
            summer = true;
        }

        public void PrintVariables()
        {
            Console.WriteLine("Character: {0}", initial);
            Console.WriteLine("String: {0}", lastName);
            Console.WriteLine("Int: {0}", year);
            Console.WriteLine("Boolean: {0}", summer);
        }
    }
}
