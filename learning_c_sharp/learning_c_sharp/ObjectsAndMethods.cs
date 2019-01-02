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


        public void ReturningNothing()
        {
            Console.WriteLine("This method returns nothing");
        }


        public string ReturningString()
        {
            Console.WriteLine("This method returns a String");
            return "Hello from Method call";
        }


        public void RequireParameters(string greeting)
        {
            Console.WriteLine("{0} from this method call", greeting);
        }
    }
}
