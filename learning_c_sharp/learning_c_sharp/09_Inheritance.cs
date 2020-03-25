using System;
namespace learning_c_sharp
{
    public class Animal
    {
        public string color { get; set; }
        public double size { get; set; }

        public void sound()
        {
            Console.WriteLine("Rawrr I am an animal");
        }

        public void eat()
        {
            Console.WriteLine("I am eating happily");
        }
    }

    public class Cat: Animal
    {
        public string furColor { get; set; }
        public int legs { get; set; }

        public Cat(string color, double size, int legs)
        {
            this.color = color;
            this.furColor = color;
            this.size = size;
            this.legs = legs;

            this.sound();
            Console.WriteLine(
                "I am a {0} cat with {1} legs and I am {2} cm tall",
                this.color,
                this.legs,
                this.size
            );
        }
    }
}
