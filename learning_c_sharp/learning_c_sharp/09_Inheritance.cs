using System;
namespace learning_c_sharp
{
    public abstract class Animal
    {
        protected string Color { get; set; }
        protected double Size { get; set; }

        public Animal(string color, double size)
        {
            Color = color;
            Size = size;
        }

        protected abstract void Sound();

        protected abstract void Eat();
    }

    public class Cat: Animal
    {
        private string FurColor { get; set; }
        private int Legs { get; set; }

        public Cat(string color, double size, int legs)
            : base(color, size)
        {
            FurColor = color;
            Legs = legs;

            Sound();
            Console.WriteLine(
                "I am a {0} cat with {1} legs and I am {2} cm tall",
                Color,
                Legs,
                Size
            );
        }

        protected override void Sound()
        {
            Console.WriteLine("Miauuu");
        }

        protected override void Eat()
        {
            Console.WriteLine("I'm eating");  
        }
    }
}
