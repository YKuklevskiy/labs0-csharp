using System;

namespace FiveSubClasses.Classes
{
    class Otter : Animal
    {

        public Otter(int age, bool domestic)
        {

            Name = "Выдра";
            Age = age;
            Genus = "Lutra";
            Domestic = domestic;
            if (Domestic)
                Habitat = "Жилище хозяина";
            else
                Habitat = "Лесные реки";

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
