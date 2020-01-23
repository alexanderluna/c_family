using System;
namespace learning_c_sharp
{
    public class ObjectsAndMethods
    {
        public ObjectsAndMethods()
        {
            Console.WriteLine("===> Setting up Objects and methods");
        }


        public static void NoInstanceNeeded()
        {
            Console.WriteLine("This method doesn't need the `new` keyword");
        }


        private void ReturningNothing()
        {
            Console.WriteLine("This method returns nothing");
        }


        private string ReturningString()
        {
            Console.WriteLine("This method returns a String");
            return "Hello from Method call";
        }


        private void RequireParameters(string greeting)
        {
            Console.WriteLine("{0} from this method call", greeting);
        }


        public void ExecuteMethods()
        {
            ReturningNothing();
            ReturningString();
            RequireParameters("hello");
        }
    }
}
