using System;
namespace learning_c_sharp
{
    public class Loops
    {
        private readonly string[] months;

        public Loops()
        {
            Console.WriteLine("===> Getting the loops ready");
            months = new string[] { "January", "February", "March", "April", "May", "June" };
        }


        public void WhileLoop()
        {
            bool looping = true;
            while (looping)
            {
                Console.WriteLine("While loop executing");
                looping = false;
            }
        }


        public void ForLoop()
        {
            Console.WriteLine("For loop executing 5 times");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("iteration {0}", i);
            }
        }


        public void ForEachLoop()
        {
            Console.WriteLine("ForEach loop executing");
            foreach (var month in months)
            {
                Console.WriteLine(month);
            }
        }
    }
}
