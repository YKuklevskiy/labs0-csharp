using System;

namespace FiveSubClasses.Classes
{
    class Dog : Animal
    {

        public Dog(int age, bool domestic)
        {

            Name = "Собака";
            Age = age;
            Genus = "Canis";
            Domestic = domestic;
            if (Domestic)
                Habitat = "Жилище хозяина";
            else
                Habitat = "Улица";

        }

        public override void Shelter()
        {

            if (Domestic)
                Console.WriteLine("Животное уже домашнее.\n");
            else
            {
                Domestic = true;
                Console.WriteLine("Животное приючено.\n");
                Habitat = "Жилище хозяина";
            }

        }

    }
}
