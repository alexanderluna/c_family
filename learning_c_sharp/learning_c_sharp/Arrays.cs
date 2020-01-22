using System;
namespace learning_c_sharp
{
    public class Arrays
    {
        private readonly string[] names = new string[3] {
            "Alexander",
            "John",
            "Bob"
        };

        public Arrays()
        {
            Console.WriteLine("===> Setting up Arrays");
            PrintArrays();
        }

        private void PrintArrays()
        {
            Console.WriteLine("Arrays has {0} items", names.Length);
            Console.WriteLine(string.Join(", ", names));
        }
    }
}
