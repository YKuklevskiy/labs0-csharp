using System;

namespace TwoClasses
{
    class Person
    {

        public Person(string name, float age, int height)
        {
            Name = name;
            Age = age;
            Height = height;
            if (age >= 18)
                legal = true;
            else
                legal = false;
        }

        private readonly bool legal = false;

        private Animal pet = null;

        public string Name { get; set; }

        public float Age { get; set; }

        public int Height { get; set; }

        public void ShelterAnimal(Animal pet)
        {

            if(!pet.Domestic)
                Console.WriteLine($"\nЭто животное - {pet.Species} - не домашнее, его нельзя приютить.");
            else if (!legal)
                Console.WriteLine($"\nВы, {Name}, еще слишком малы, чтобы брать на себя такую ответственность!");
            else
                this.pet = pet;

        }

        public void ShowInfo()
        {

            Console.WriteLine($"\nИнформация о персоне:\nИмя: {Name}\nВозраст: {Age} лет\nРост: {Height}");
            if(pet != null)
            {
                Console.WriteLine("Информация о питомце персоны:");
                pet.ShowInfo();
            }

        }

    }
}
