using System;

namespace FiveSubClasses.Classes
{
    class Animal
    {

        public Animal() { }

        public Animal(string name, float age, string genus, bool domestic, string habitat)
        {
            Name = name;
            Age = age;
            Genus = genus;
            Domestic = domestic;
            Habitat = habitat;
        }

        public string Name { get; set; }

        public float Age { get; set; }

        public string Genus { get; set; }

        public bool Domestic { get; set; }

        public string Habitat { get; set; }

        public void GrowUp() { Age++; }

        public virtual void Shelter()
        {

            if(Domestic)
                Console.WriteLine("Животное уже домашнее.\n");
            else
            {
                Domestic = true;
                Console.WriteLine("Животное приючено.\n");
            }

        }

        public void ShowInfo()
        {

            Console.WriteLine($"Животное: {Name}\nВозраст: {Age} лет\nРод животного: {Genus}");

            if (Domestic) Console.WriteLine("Домашнее животное.");
            else Console.WriteLine("Не домашнее животное.");

            Console.WriteLine($"Среда обитания: {Habitat}\n");

        }

    }
}
