using System;

namespace learning_c_sharp {

    class Program {

        static void Main (string[] args) {
            Console.WriteLine ("===> Variables Start");
            var variable = new Variables ();
            variable.PrintVariables ();
            Console.WriteLine ("===> Variables End\n");

            Console.WriteLine ("===> Arrays Start");
            var arrays = new Arrays ();
            arrays.PrintArrays ()
            Console.WriteLine ("===> Arrays End\n");

            Console.WriteLine ("===> Loops Start");
            var loops = new Loops ();
            loops.ExecuteLoops ();
            Console.WriteLine ("===> Loops End\n");

            Console.WriteLine ("===> Conditionals Start");
            var conditionals = new Conditionals ();
            conditionals.ExecuteConditionals ();
            Console.WriteLine ("===> Conditionals End\n");

            Console.WriteLine ("===> Objects and Methods Start");
            var objectsAndMethods = new ObjectsAndMethods ();
            objectsAndMethods.ExecuteMethods ();
            ObjectsAndMethods.NoInstanceNeeded ();
            Console.WriteLine ("===> Objects and Methods End\n");
        }
    }
}