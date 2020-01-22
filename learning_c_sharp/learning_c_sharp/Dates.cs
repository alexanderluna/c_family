using System;
namespace learning_c_sharp
{
    public class Dates
    {
        private DateTime createdAt = new DateTime(2020, 1, 20);
        private DateTime today = DateTime.Today;


        public Dates()
        {
            Console.WriteLine("===> Configuring dates");
            ExecuteDates();
        }


        private void ExecuteDates()
        {
            Console.WriteLine("I was created at: {0}", createdAt);
            Console.WriteLine("Today is: {0}", today);
            Console.WriteLine("5 days from Today is: {0}", today.AddDays(5));
        }
    }
}
