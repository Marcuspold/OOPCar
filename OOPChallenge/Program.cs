using System;

namespace OOPChallenge
{
    class Program
    {
        class Dog
        {
            string name;
            int spots;
            double happiness;

            public Dog(string _name, int _spots)
            {
                name = _name;
                spots = _spots;
                happiness = 0;
                Console.WriteLine($"The Dog {name} has been created.");
            }

            public double Happiness
            {
                get { return happiness; }
            }

            public void Barks()
            {
                Console.WriteLine("Woof-Woof");
                happiness += 0.2;
            }
            public void Wiggle()
            {
                Console.WriteLine("Wiggle-Wiggle");

            }
            public void Rename(string newName) //rename
            {
                name = newName;
            }
            public void ShowDogData()
            {
                Console.WriteLine($"Name: {name}; Spots: {spots}; Happy {happiness};");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Good Morning!");
            Dog newDog = new Dog("Poggy", 10);
            
            Console.WriteLine($"The Level Of Happiness: {newDog.Happiness}");

            while(newDog.Happiness != 1)
            {
                newDog.Barks();
            }
            newDog.Wiggle();

            Console.WriteLine("Name the Dog:");
            string newDogName = Console.ReadLine();
            newDog.Rename(newDogName);
            newDog.ShowDogData();


        }
    }
}
