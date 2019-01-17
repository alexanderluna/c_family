using System;

namespace learning_c_sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===> Variables Start");
            var variable = new Variables();
            Console.WriteLine("Character: {0}", variable.initial);
            Console.WriteLine("String: {0}", variable.lastName);
            Console.WriteLine("Int: {0}", variable.year);
            Console.WriteLine("Boolean: {0}", variable.summer);
            Console.WriteLine("===> Variables End\n");


            Console.WriteLine("===> Arrays Start");
            var arrays = new Arrays();
            Console.WriteLine("Arrays has {0} items", arrays.names.Length);
            Console.WriteLine(String.Join(',', arrays.names));
            Console.WriteLine("===> Arrays End\n");


            Console.WriteLine("===> Loops Start");
            var loops = new Loops();
            loops.WhileLoop();
            loops.ForLoop();
            loops.ForEachLoop();
            Console.WriteLine("===> Loops End\n");


            Console.WriteLine("===> Conditionals Start");
            var conditionals = new Conditionals();
            conditionals.IfElseStatement("winter");
            conditionals.SwitchCaseStatement(5);
            Console.WriteLine("===> Conditionals End\n");


            Console.WriteLine("===> Objects and Methods Start");
            var objectsAndMethods = new ObjectsAndMethods();
            ObjectsAndMethods.NoInstanceNeeded();
            objectsAndMethods.ReturningNothing();
            objectsAndMethods.ReturningString();
            objectsAndMethods.RequireParameters("Hello");
            Console.WriteLine("===> Objects and Methods End\n");
        }
    }
}
