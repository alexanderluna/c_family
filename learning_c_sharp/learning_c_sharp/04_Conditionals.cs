using System;

namespace learning_c_sharp
{
    public class Conditionals
    {
        private enum Week
        {
            Monday = 1,
            Tuesday = 2,
            Wednesday = 3,
            Thursday = 4,
            Friday = 5,
            Saturday = 6,
            Sunday = 7
        }


        public Conditionals()
        {
            Console.WriteLine("===> Conditions getting configured");
            ExecuteConditionals();
        }


        private void IfElseStatement(string season)
        {
            Console.WriteLine("Is it Summer ?");
            if (season == "winter")
            {
                Console.WriteLine("No, it's winter");
            } else
            {
                Console.WriteLine("Yes, it's summer");
            }
        }


        private void SwitchCaseStatement(int dayOfWeek)
        {
            switch ((Week) dayOfWeek)
            {
                case Week.Monday:
                    Console.WriteLine("Its Monday");
                    break;
                case Week.Tuesday:
                    Console.WriteLine("Its Tuesday");
                    break;
                case Week.Wednesday:
                    Console.WriteLine("Its Wednesday");
                    break;
                case Week.Thursday:
                    Console.WriteLine("Its Thursday");
                    break;
                case Week.Friday:
                    Console.WriteLine("Its Friday");
                    break;
                case Week.Saturday:
                    Console.WriteLine("Its Saturday");
                    break;
                case Week.Sunday:
                    Console.WriteLine("Its Sunday");
                    break;
                default:
                    Console.WriteLine("I don't know that day");
                    break;
            }
        }


        private void ExecuteConditionals()
        {
            IfElseStatement("winter");
            SwitchCaseStatement(5);
        }
    }
}
