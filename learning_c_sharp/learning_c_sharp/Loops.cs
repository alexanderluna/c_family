using System;
namespace learning_c_sharp
{
    public class Loops
    {
        private readonly string[] months;

        public Loops()
        {
            Console.WriteLine("===> Setting up Arrays");
            months = new string[] {
                "January",
                "February",
                "March",
                "April",
                "May",
                "June",
                "July",
                "August",
                "September",
                "October",
                "November",
                "December"
            };
        }


        private void WhileLoop()
        {
            bool looping = true;
            while (looping)
            {
                Console.WriteLine("While loop executing once");
                looping = false;
            }
        }


        private void ForLoop()
        {
            Console.WriteLine("For loop executing 5 times");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("iteration {0}", i);
            }
        }


        private void ForEachLoop()
        {
            Console.WriteLine("ForEach loop executing for Month in the Year");
            foreach (var month in months)
            {
                Console.WriteLine(month);
            }
        }

        public void ExecuteLoops()
        {
            WhileLoop();
            ForLoop();
            ForEachLoop();
        }
    }
}
