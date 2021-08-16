using System;

namespace TwoClasses
{
    class Animal
    {

        public Animal(string name, float age, string species, bool domestic)
        {
            Name = name;
            Age = age;
            Species = species;
            Domestic = domestic;
        }

        public string Name { get; set; }

        public float Age { get; set; }

        public string Species { get; set; }

        public bool Domestic { get; set; }

        public void ShowInfo()
        {

            Console.WriteLine($"Кличка: {Name}\nВозраст: {Age} лет\nТип животного: {Species}");
            if (Domestic) Console.WriteLine("Домашнее животное.");
            else          Console.WriteLine("Не домашнее животное.");

        }

    }
}
