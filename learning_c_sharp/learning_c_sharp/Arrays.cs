using System;
namespace learning_c_sharp
{
    public class Arrays
    {
        private string[] names;

        public Arrays()
        {
            names = new string[3] { "Alexander", "John", "Bob" };
        }

        public void PrintArrays()
        {
            Console.WriteLine("Arrays has {0} items", names.Length);
            Console.WriteLine(string.Join(',', names));
        }
    }
}
