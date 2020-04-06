using System;
namespace learning_c_sharp
{
    public class Animal
    {
        protected string Color { get; set; }
        protected double Size { get; set; }

        protected void Sound()
        {
            Console.WriteLine("Rawrr I am an animal");
        }

        protected void Eat()
        {
            Console.WriteLine("I am eating happily");
        }
    }

    public class Cat: Animal
    {
        private string FurColor { get; set; }
        private int Legs { get; set; }

        public Cat(string color, double size, int legs)
        {
            this.Color = color;
            this.FurColor = color;
            this.Size = size;
            this.Legs = legs;

            this.Sound();
            Console.WriteLine(
                "I am a {0} cat with {1} legs and I am {2} cm tall",
                this.Color,
                this.Legs,
                this.Size
            );
        }
    }
}
