using System;
namespace learning_c_sharp
{
    public class GetterSetter
    {
        public DateTime CreationTime { get; private set; }


        public GetterSetter(DateTime createdAt)
        {
            CreationTime = createdAt;
        }

        public int Age
        {
            get
            {
                var timeSpan = DateTime.Today - CreationTime;
                var years = timeSpan.Days / 365;
                Console.WriteLine("This document is: {0} years old", years);
                return years;
            }
        }
    }
}
